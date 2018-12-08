using System;
using System.Collections.Generic;
using System.Data;
using Entities;
using System.Data.SqlClient;

namespace Department.DAL
{
    public class EmployeeDAOdb : IEmployeeDAO, IDisposable
    {
        private SqlConnection _connection;

        public EmployeeDAOdb()
        {
            _connection = new SqlConnection(DatabaseConfig.GetConnectionString());
        }

        public void EditOrAdd(Employee employee, string commandText)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            foreach (var id in employee.RewardsIdList)
            {
                table.Rows.Add(id);
            }
            using (SqlCommand command = _connection.CreateCommand())
            {
                if (commandText == "UpdateEmployee")
                {
                    command.Parameters.AddWithValue("@id", employee.ID);
                }  
                command.CommandText = commandText;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@lastName", employee.LastName);
                command.Parameters.AddWithValue("@firstName", employee.FirstName);
                command.Parameters.AddWithValue("@birth", employee.Birth);
                SqlParameter tvparam = command.Parameters.AddWithValue("@rewardIds" , table);
                tvparam.SqlDbType = SqlDbType.Structured;
               // tvparam.TypeName = "dbo.RewardsIds";
                _connection.Open();
                var result = command.ExecuteNonQuery();
                _connection.Close();
            }
        }

        public void Edit(Employee employee)
        {
             string  commandText = "UpdateEmployee";
             EditOrAdd(employee, commandText);
        }

        public void Add(Employee employee)
        {
            string commandText = "AddEmployee";
            EditOrAdd(employee, commandText);

                //var result = command.ExecuteScalar();
                //var employeeId = (int)result;
                //employee.ID = employeeId;

        }

        public IEnumerable<Employee> GetList()
        {
            var employees = new List<Employee>();
            _connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT Id, LastName, FirstName, Birth FROM employees", _connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string lastName = (string)reader["LastName"];
                    string firstName = (string)reader["FirstName"];
                    DateTime birth = (DateTime)reader["Birth"];
                    employees.Add(new Employee()
                    {
                        ID = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Birth = birth,
                    });    
                }
                 _connection.Close();
                foreach (var employee in employees)
                {
					employee.Rewards =  AddEmployeeRewards(employee.ID);
                }
                return employees;
            }
        }

        public List<Reward> AddEmployeeRewards(int ID)
        {
            List<Reward> rewards = new List<Reward>();
            _connection.Open();
            using (SqlCommand command2 = new SqlCommand("GetRewardsForEmployeeById", _connection))   ///////
            {
                command2.CommandType = CommandType.StoredProcedure;
                command2.Parameters.AddWithValue("@idemployee", ID);
                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    int rewardsId = (int)reader2["Id"];
                    string title = (string)reader2["Title"];
                    string description = (string)reader2["Description"];
                    rewards.Add(new Reward()
                    {
                        ID = rewardsId,
                        Title = title,
                        Description = description
                    });
                }
            }
            _connection.Close();
            return rewards;
        }

        public void Remove(Employee employee)
        {
            _connection.Open();
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteEmployee";
                command.Parameters.AddWithValue("@employeeId", employee.ID);
                var result = command.ExecuteNonQuery();
            }
            _connection.Close();
        }

        public IEnumerable<Employee> InitList()
        {
            return GetList();
        }

        public void Dispose()
        {
            if (_connection != null)
                _connection.Dispose();
        }
    }
}
