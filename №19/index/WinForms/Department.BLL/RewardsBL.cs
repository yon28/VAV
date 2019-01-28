using Department.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Department.BLL
{
    public class RewardsBL
    {
        private readonly IRewardDAO rewardsDAO;

        public RewardsBL()
        {
            // rewardsDAO = new RewardDAO();
            rewardsDAO = new RewardDAOdb();
        }

        public IEnumerable<Reward> InitList()
        {
            return rewardsDAO.InitListRewards();
        }

        public List<Reward> GetList()
        {
            return rewardsDAO.GetList();
        }

        public IEnumerable<Reward> SortRewards(string ascendingORdescending)
        {
            IEnumerable<Reward> rewards;
            if (ascendingORdescending == "ascending")
            {
                rewards = (from s in GetList()
                             orderby s.Title ascending
                             select s).ToList();
            }
            else
            {
                rewards = (from s in GetList()
                             orderby s.Title descending
                             select s).ToList();
            }
            foreach (Reward reward in rewardsDAO.GetList())
            {
                Remove(reward);
            }
            foreach (Reward reward in rewards)
            {
                Add(reward);
            }
            return rewards;
        }

        public void Add(string title, string description)
        {
            Reward reward = new Reward
            {
                Title = title,
                Description = description,
            };
            this.Add(reward);
        }

        public void Add(Reward reward)
        {
            if (reward == null)
                throw new ArgumentException("награда");
             rewardsDAO.Add(reward);
        }

        public void Remove(string title, string description)
        {
            Reward reward = new Reward
            {
                Title = title,
                Description = description,
            };
            this.Remove(reward);
        }

        public void Remove(Reward reward)
        {
            if (reward == null)
                throw new ArgumentException("пользователь");
            rewardsDAO.Remove(reward);
        }

        public void Edit(string title, string description)
        {
            Reward reward = new Reward
            {
                Title = title,
                Description = description,
            };
            this.Edit(reward);
        }

        public void Edit(Reward reward)
        {
            if (reward == null)
                throw new ArgumentException("пользователь");
            rewardsDAO.Edit(reward);
        }
    }
}
