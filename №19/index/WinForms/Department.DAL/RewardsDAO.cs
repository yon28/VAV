using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Department.DAL
{
    public class RewardDAO : IRewardDAO
    {
        private List<Reward> rewards = new List<Reward>();

        public IEnumerable <Reward> InitListRewards()
        {
            rewards.Add(new Reward()
            {
                Title = "Награда1",
                Description = "Описание1",
                ID = 1
            });
            rewards.Add(new Reward()
            {
                Title = "Награда2",
                Description = "Описание2",
                ID = 2
            });
            rewards.Add(new Reward()
            {
                Title = "Награда3",
                Description = "Описание3",
                ID = 3
            });
            return GetList();
        }

        public void Add(Reward reward)
        {
            if (reward == null)
                throw new ArgumentException("награда");
            reward.ID = Math.Abs(GetHashCode());
            rewards.Add(reward);
        }

        public void Remove(Reward reward)
        {
            if (reward == null)
                throw new ArgumentException("пользователь");

            rewards.Remove(reward);
        }

        public List<Reward> GetList()
        {
            return rewards;
        }

        public void Edit(Reward reward)
        {
            var existingReward = rewards.FirstOrDefault(u => u.ID == reward.ID);
            if (existingReward != null)
            {
                existingReward.Title = reward.Title;
                existingReward.Description = reward.Description;
            }
        }
    }
   
}
