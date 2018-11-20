using Department.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Department.BLL
{
    public class RewardsBL
    {
        private readonly IRewardDAO rewardsDAO;

        public RewardsBL()
        {
            rewardsDAO = new RewardDAO();
            //rewardsDAO = new RewardDAOdb();
        }

        public IEnumerable<Reward> InitList()
        {
            return rewardsDAO.InitList();
        }

        public IEnumerable<Reward> SortRewardsByFullNameAsc()
        {
            return (from s in GetList()
                    orderby s.Title ascending
                    select s);
        }

        public IEnumerable<Reward> SortRewardsByFullNameDesc()
        {
            return (from s in GetList()
                    orderby s.Title descending
                    select s).ToList();
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





        public IEnumerable<Reward> GetList()
        {
            return rewardsDAO.GetList();
        }
    }
}
