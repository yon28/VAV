using Department.BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
//using TestMvc2.Models;

namespace TestMvc2.Controllers
{
    public class RewardController : Controller
    {
		EmployeesBL employeesBL;
		RewardsBL rewardsBL;
		//public static List<Reward> rewards = new List<Reward>
  //      {
  //          new Reward { Id = 1, Title = "reward1", Description = "first userovich"},
  //          new Reward { Id = 2, Title = "reward2", Description = "second userovich"},
  //          new Reward { Id = 3, Title = "reward3", Description = "third userovich"}
  //      };

		public ActionResult Index()
		{
			return View(rewardsBL.GetList());
		}
		public RewardController()
        {
            employeesBL = new EmployeesBL();
			rewardsBL = new RewardsBL();
		}
        public ActionResult Cancel()
        {
            return View("Cancel");
        }

        public ActionResult Del(int rewardId)
        {
            var currentReward = rewardsBL.GetList().FirstOrDefault(u => u.ID == rewardId);
			return View("Del");
        }

        public ActionResult Edit(int rewardId)
        {
			var rewards = new List<Reward>();////    
			var currentReward = rewardsBL.GetList().FirstOrDefault(u => u.ID == rewardId);
            return View(Entities.RewardViewModel.GetViewModel(currentReward, rewards));
        }

        public ActionResult Add()
        {
            return View("Edit", null);
        }
	
		public ActionResult Delete(int rewardId)
        {
            var currentReward = rewardsBL.GetList().FirstOrDefault(u => u.ID == rewardId);
			if (currentReward != null)
            {
                rewardsBL.Remove(currentReward);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Save(Entities.RewardViewModel rewardModel)
        {
            if (rewardModel != null)
            {
                if (rewardModel.ID == default(int))
                {
                    // add
                    rewardsBL.Add(rewardModel.ToReward());
                }
                else
                {
                    // update
                    var currentReward = rewardsBL.GetList().FirstOrDefault(u => u.ID == rewardModel.ID);
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