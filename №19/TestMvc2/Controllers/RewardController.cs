using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TestMvc2.Models;

namespace TestMvc2.Controllers
{
    public class RewardController : Controller
    {

        public static List<Reward> rewards = new List<Reward>
        {
            new Reward { Id = 1, Title = "reward1", Description = "first userovich"},
            new Reward { Id = 2, Title = "reward2", Description = "second userovich"},
            new Reward { Id = 3, Title = "reward3", Description = "third userovich"}
        };
      
        public RewardController()
        {
            //service = new DataService();
        }

        public ActionResult Index()
        {
            return View(rewards);
        }

        public ActionResult Edit(int rewardId)
        {
            var currentReward = rewards.FirstOrDefault(u => u.Id == rewardId);
            return View(RewardViewModel.GetViewModel(currentReward, rewards));
        }

        public ActionResult Add()
        {
            return View("Edit", null);
        }

        public ActionResult Delete(int rewardId)
        {
            var currentReward = rewards.FirstOrDefault(u => u.Id == rewardId);
            if (currentReward != null)
            {
                rewards.Remove(currentReward);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Save(RewardViewModel rewardModel)
        {
            if (rewardModel != null)
            {
                if (rewardModel.Id == default(int))
                {
                    // add
                    rewards.Add(rewardModel.ToReward());
                }
                else
                {
                    // update
                    var currentReward = rewards.FirstOrDefault(u => u.Id == rewardModel.Id);
                    if (currentReward != null)
                    {
                        var reward = rewardModel.ToReward();
                        currentReward.Title = reward.Title;
                        currentReward.Description = reward.Description;
                    }
                }
            }

            return RedirectToAction("Index");
        }
    }
}