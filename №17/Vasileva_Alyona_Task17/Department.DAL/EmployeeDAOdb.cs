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
            GetList();
        }

        public void Edit(Employee employee)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateEmployee";
                command.Parameters.AddWithValue("@id", employee.ID);
                command.Parameters.AddWithValue("@lastName", employee.LastName);
                command.Parameters.AddWithValue("@firstName", employee.FirstName);
                command.Parameters.AddWithValue("@birth", employee.Birth);
                _connection.Open();
                var result = command.ExecuteNonQuery();
                _connection.Close();
                // AddEmployeeRewards(employee);

            }
        }

        public void Add(Employee employee)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "InsertEmployee";
                command.Parameters.AddWithValue("@lastName", employee.LastName);
                command.Parameters.AddWithValue("@firstName", employee.FirstName);
                command.Parameters.AddWithValue("@birth", employee.Birth);
                _connection.Open();
                var result = command.ExecuteScalar();
                var employeeId = (int)result;
                employee.ID = employeeId;
                _connection.Close();
               // AddEmployeeRewards(employee);

            }
        }

        public void AddEmployeeRewards(Employee employee)
        {
            DataTable tempRewardsTable = new DataTable();
            tempRewardsTable.Columns.Add("RewardId", typeof(int));
            if (employee.RewardsIdList != null)
            {
                foreach (var RewardsId in employee.RewardsIdList)
                {
                    tempRewardsTable.Rows.Add(RewardsId);
                }
                using (var command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddEmployeeRewards";
                    command.Parameters.AddWithValue("@employeeId", employee.ID);
                    var rewardsTableParameter = command.Parameters.AddWithValue("@rewardIds", tempRewardsTable);
                    rewardsTableParameter.SqlDbType = SqlDbType.Structured;
                    _connection.Open();
                    var result = command.ExecuteNonQuery();
                    _connection.Close();
                }
            }
        }
        /*CREATE PROCEDURE AddEmployeeRewards( 
            InsertedId  int, rewardIds RewardsIds readonly)
        AS
        BEGIN
            DECLARE @employeeId AS TABLE(id int)
            INSERT INTO @employeeId VALUES(InsertedId)
            INSERT INTO Relations
            SELECT [@employeeId].id, [@rewardIds].id FROM @rewardIds, @employeeId
        END
        GO*/
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

        public IEnumerable<Employee> GetList()
        {
            _connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT Id, LastName, FirstName, Birth FROM employees", _connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                var employees = new List<Employee>();

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
                        Birth = birth
                    });

                }
                _connection.Close();
                return employees;
            }
        }

        public void Dispose()
        {
            if (_connection != null)
                _connection.Dispose();
        }
    }


}
