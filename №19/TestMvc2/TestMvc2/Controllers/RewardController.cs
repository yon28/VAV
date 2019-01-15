using Department.BLL;
using Entities;
using System.Linq;
using System.Web.Mvc;

namespace TestMvc2.Controllers
{
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

        public ActionResult Save(RewardViewModel rewardModel)
        {
            if (rewardModel != null)
            {
                if (rewardModel.ID == default(int))// add
                {
                    rewardsBL.Add(rewardModel.ToReward());
                }
                else // update
                {
                    var reward = rewardModel.ToReward();
                    rewardsBL.Edit(reward);
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Add()
        {
            return View("Edit", null);
        }

        public ActionResult Edit(int rewardId)
        {
            var rewards = rewardsBL;
            var currentReward = rewardsBL.GetList().FirstOrDefault(u => u.ID == rewardId);
            return View(RewardViewModel.GetViewModel(currentReward, rewards.GetList()));
        }



        public ActionResult Del(int rewardId)
        {
            var currentReward = rewardsBL.GetList().FirstOrDefault(u => u.ID == rewardId);
            return View("Del");
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
    }
}