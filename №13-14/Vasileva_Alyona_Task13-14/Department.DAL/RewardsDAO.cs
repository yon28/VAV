using Entities;
using System;
using System.Collections.Generic;

namespace Department.DAL
{
    public class RewardDAO : IRewardDAO
    {
        private List<Reward> rewards = new List<Reward>();
        public IEnumerable<Reward> InitList()
        {
            Add(new Reward()
            {
                Title = "Награда1",
                Description = "Описание1",

            });
            Add(new Reward()
            {
                Title = "Награда2",
                Description = "Описание2",
            });
            Add(new Reward()
            {
                Title = "Награда3",
                Description = "Описание3",
            });

            return GetList();
        }

        public void Add(Reward reward)
        {
            if (reward == null)
                throw new ArgumentException("награда");

            rewards.Add(reward);
        }

        public IEnumerable<Reward> GetList()
        {
            return rewards;
        }

        public void Remove(Reward reward)
        {
            if (reward == null)
                throw new ArgumentException("пользователь");

            rewards.Remove(reward);
        }
    }

    public class Rewardsdb : IRewardDAO
    {
        public void Add(Reward reward)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reward> GetList()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reward> InitList()
        {
            throw new NotImplementedException();
        }

        public void Remove(Reward reward)
        {
            throw new NotImplementedException();
        }
    }
}
