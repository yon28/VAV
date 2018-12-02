using System.Collections.Generic;
using Entities;

namespace Department.DAL
{
    public interface IRewardDAO
    {
        void Add(Reward reward);
        List<Reward> GetList();
        void Remove(Reward reward);
        IEnumerable<Reward> InitListRewards();
        void Edit(Reward reward);
    }
}
