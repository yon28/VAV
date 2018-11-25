using System;
using System.Collections.Generic;
using System.Data;
using Entities;
using System.Data.SqlClient;


namespace Department.DAL
{
    public class RewardDAOdb : IRewardDAO, IDisposable
    {
        private SqlConnection _connection;

        public RewardDAOdb()
        {
            _connection = new SqlConnection(DatabaseConfig.GetConnectionString());
            GetList();
        }

        public IEnumerable<Reward> GetList()
        {
            using (SqlCommand command = new SqlCommand("GetRewards", _connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                var rewards = new List<Reward>();
                _connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string title = (string)reader["Title"];
                    string description = (string)reader["Description"];
                    rewards.Add(new Reward()
                    {
                        ID = id,
                        Description = description,
                        Title = title,
                    });
                }
                _connection.Close();
                return rewards;
            }
        }

        public void Add(Reward reward)
        {   
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText ="AddRewards";
                command.Parameters.AddWithValue("@title", reward.Title);
                command.Parameters.AddWithValue("@description", reward.Description);
                _connection.Open();
                var result = command.ExecuteNonQuery();
                _connection.Close();
            } 
        }


        public void Edit(Reward reward)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateReward";
                command.Parameters.AddWithValue("@id", reward.ID);
                command.Parameters.AddWithValue("@title", reward.Title);
                command.Parameters.AddWithValue("@description", reward.Description);
                _connection.Open();
                var result = command.ExecuteNonQuery();
                _connection.Close();
            }
        }

        public void Remove(Reward reward)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = String.Format("DeleteReward");
                command.Parameters.AddWithValue("@rewardId", reward.ID);
                _connection.Open();
                var result = command.ExecuteNonQuery();
                _connection.Close();
            }
        }

        public IEnumerable<Reward> InitListRewards()
        {
            return GetList();
        }
       
        public void Dispose()
        {
            if (_connection != null)
                _connection.Close();
        }
    }
}
