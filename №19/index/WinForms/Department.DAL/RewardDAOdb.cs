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
        }

        public List<Reward> GetList()
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

        public void ChangeReward(Reward reward, string commandText)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = commandText;
                if (commandText != "AddRewards")
                {
                    command.Parameters.AddWithValue("@id", reward.ID);
                }
                if (commandText != "DeleteReward")
                {
                    command.Parameters.AddWithValue("@title", reward.Title);
                    command.Parameters.AddWithValue("@description", reward.Description);
                }
                _connection.Open();
                var result = command.ExecuteNonQuery();
                _connection.Close();
            }
        }

        public void Edit(Reward reward)
        {
            ChangeReward(reward, "UpdateReward");
        }

        public void Add(Reward reward)
        {
            ChangeReward(reward, "AddRewards");
        }
        
        public void Remove(Reward reward)
        {
            ChangeReward(reward, "DeleteReward");
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
