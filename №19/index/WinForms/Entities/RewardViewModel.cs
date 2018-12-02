using System.Collections.Generic;
using System.Linq;

namespace Entities
{
    public class RewardViewModel
    {
       public int ID { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool Checked { get; set; }

        public static RewardViewModel GetViewModel(Reward reward, List<Reward> checkedRewards)
        {
            var model = new RewardViewModel();
            model.ID = reward.ID;
            model.Title = reward.Title;
            model.Description = reward.Description;
            model.Checked = checkedRewards.Any(r => r.ID == reward.ID);
            return model;
        }

        public Reward ToReward()
        {
            return new Reward
            {
                ID = ID,
                Title = Title,
                Description = Description
            };
        }
    }
}