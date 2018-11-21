using System.Collections.Generic;
using Entities;

namespace Department.DAL
{
    public interface IRewardDAO
    {
        void Add(Entities.Reward reward);
        System.Collections.Generic.IEnumerable<Entities.Reward> GetList();
        void Remove(Entities.Reward reward);
        IEnumerable<Reward> InitListRewards();
    }
}
