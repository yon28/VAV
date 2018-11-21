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
            InitConnection();
        }

        private void InitConnection()
        {
            _connection = new SqlConnection(DatabaseConfig.GetConnectionString());
            _connection.Open();
            _connection.StateChange += ConnectionStateChange;
        }

        void ConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState == ConnectionState.Broken)
            {
                InitConnection();
            }
        }

         public void Add(Employee employee)
         {
             using (SqlCommand command = _connection.CreateCommand())
             {
                command.CommandText = String.Format("INSERT INTO employees(LastName, FirstName, Birth) VALUES(@lastName, @firstName, @birth)");
                command.Parameters.Add(new SqlParameter("@lastName", SqlDbType.NVarChar,150));
                command.Parameters.Add(new SqlParameter("@firstName", SqlDbType.NVarChar,150));
                command.Parameters.Add(new SqlParameter("@birth", SqlDbType.DateTime));
                command.Prepare();// "Для метода SqlCommand.Prepare требуется, чтобы всем параметрам переменной длины был в явном виде присвоен ненулевой Size."
                command.Parameters[0].Value = employee.LastName;
                command.Parameters[1].Value = employee.FirstName;
                command.Parameters[2].Value = DateTime.Now;//employee.Birth;
                //    AddEmployeeRewards(employee);
                var result = command.ExecuteNonQuery();

            }
         }

 private void AddEmployeeRewards(Employee employee)
        {
            DataTable tempRewardsTable = new DataTable();
            tempRewardsTable.Columns.Add("RewardId", typeof(int));
            foreach (var r in employee.Rewards)
            {
               // tempRewardsTable.Rows.Add(r.Id);
            }

            using (var command = new SqlCommand())
            {
             //   command.CommandText = "InsertEmployeeRewards";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = _connection;
                command.Parameters.AddWithValue("@employeeId", employee.ID);
                var rewardsTableParameter = command.Parameters.AddWithValue("@rewardIds",tempRewardsTable);
                rewardsTableParameter.SqlDbType = SqlDbType.Structured;
                //command.ExecuteNonQuery();
            }
        }


        public void Remove(Employee employee)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = String.Format("EXEC DeleteEmployee(int) VALUES(@int)");
                command.Parameters.Remove(new SqlParameter("@int", SqlDbType.Int));
                command.Prepare();
                command.Parameters[0].Value = employee.ID;
                var result = command.ExecuteNonQuery();
            }
        }
        public IEnumerable<Employee> InitList()
        {
            using (SqlCommand command = _connection.CreateCommand())
            {

                _connection.Open();
                command.CommandText = String.Format("EXEC InitListEmployee");
                command.Prepare();
                var result = command.ExecuteNonQuery();
            }
           return GetList();

        }
        public IEnumerable<Employee> GetList()
        {
            using (SqlCommand command = new SqlCommand("SELECT Id, LastName, FirstName, Birth FROM employees", _connection))
            {
             
                SqlDataReader reader = command.ExecuteReader();
            
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string lastName = (string)reader["LastName"];
                    string firstName = (string)reader["FirstName"];
                    DateTime birth = (DateTime)reader["Birth"];
                   
                    yield return new Employee()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Birth = birth
                    };

                }
                _connection.Close();
            }
        }
        public void Dispose()
        {
            if (_connection != null)
                _connection.Dispose();
        }
    }

    public class RewardDAOdb : IRewardDAO, IDisposable
    {
        private SqlConnection _connection;

        public RewardDAOdb()
        {
            InitConnection();
        }

        private void InitConnection()
        {
            _connection = new SqlConnection(DatabaseConfig.GetConnectionString());
            _connection.Open();
            _connection.StateChange += ConnectionStateChange;
        }

        void ConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState == ConnectionState.Broken)
            {
                InitConnection();
            }
        }

        public void Add(Reward reward)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = String.Format("INSERT INTO rewards(Title, Description) VALUES(@title, @description)");
                command.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar,150));
                command.Parameters.Add(new SqlParameter("@description", SqlDbType.NVarChar,150));
                command.Prepare(); 
                command.Parameters[0].Value = reward.Title;
                command.Parameters[1].Value = reward.Description;
                var result = command.ExecuteNonQuery();
            }
        }

        public void Remove(Reward reward)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = String.Format("EXEC DeleteReward(int) VALUES(@int)");
                command.Parameters.Remove(new SqlParameter("@int", SqlDbType.Int));
                command.Prepare();
                command.Parameters[0].Value = reward.ID;
                var result = command.ExecuteNonQuery();
            }
        }
        public IEnumerable<Reward> InitListRewards()
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = String.Format("EXEC InitListReward");
                command.Prepare();
                var result = command.ExecuteNonQuery();
            }
            return GetList();

        }
        public IEnumerable<Reward> GetList()
        {
            using (SqlCommand command = new SqlCommand("SELECT Id, Title, Description FROM rewards", _connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string title = (string)reader["Title"];
                    string description = (string)reader["Description"];

                    yield return new Reward()
                    {
                        Description = description,
                        Title = title,
                    };
                }
            }
        }
        public void Dispose()
        {
            if (_connection != null)
                _connection.Dispose();
        }
    }
}
