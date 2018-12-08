using Department.BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
//using TestMvc2.Models;

namespace TestMvc2.Controllers
{
    static class Wrapper
    {
        public static EmployeesBL employeesBL = new EmployeesBL();
        public static RewardsBL rewardsBL = new RewardsBL();
        static Wrapper()
        {
            rewardsBL.InitList();
            employeesBL.InitList();
        }
    }

    public class RewardController : Controller
    {
		EmployeesBL employeesBL;
        RewardsBL rewardsBL;
        //public static List<Reward> rewards = //
        //new List<Reward>  
        //{
        //    new Reward { ID = 1, Title = "reward1", Description = "first userovich"},
        //    new Reward { ID = 2, Title = "reward2", Description = "second userovich"},
        //    new Reward { ID = 3, Title = "reward3", Description = "third userovich"}
        //};


		public RewardController()
        {
             employeesBL = Wrapper.employeesBL;
            rewardsBL = Wrapper.rewardsBL;

           // rewardsBL.InitList();
           // employeesBL.InitList();
        }

        public ActionResult Index()
		{
			return View(rewardsBL.GetList());
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

        public ActionResult Edit(int rewardId)
        {
            var rewards = rewardsBL;
            var currentReward = rewardsBL.GetList().FirstOrDefault(u => u.ID == rewardId);
            return View(RewardViewModel.GetViewModel(currentReward, rewards.GetList()));
        }

        public ActionResult Save(RewardViewModel rewardModel)
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
                    var reward = rewardModel.ToReward();
                    rewardsBL.Edit(reward);
                }
            }

            return RedirectToAction("Index");
        }
    }
}