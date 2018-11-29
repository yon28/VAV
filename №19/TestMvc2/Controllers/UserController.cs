using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TestMvc2.Models;

namespace TestMvc2.Controllers
{
    public class UserController : Controller
    {

        private static List<Reward> rewards = RewardController.rewards;
     
        private static List<User> users = new List<User>
		{
			new User { Id = 1, FirstName = "first user", LastName = "first userovich", Birth = new DateTime(1981, 10, 10), Rewards = new List<Reward> { rewards[2] } },
			new User { Id = 2, FirstName = "second user", LastName = "second userovich", Birth = new DateTime(1982, 10, 10), Rewards = new List<Reward> { rewards[1], rewards[2] } },
			new User { Id = 3, FirstName = "third user", LastName = "third userovich", Birth = new DateTime(1983, 10, 10)}
		};

		public UserController()
		{
			//service = new DataService();
		}

        public ActionResult Index()
        {
            return View(users);
        }

		public ActionResult Edit(int userId)
		{
			var currentUser = users.FirstOrDefault(u => u.Id == userId);
			return View(UserViewModel.GetViewModel(currentUser, rewards));
		}

		public ActionResult Add()
		{
			return View("Edit", null);
		}

		public ActionResult Delete(int userId)
		{
			var currentUser = users.FirstOrDefault(u => u.Id == userId);
			if (currentUser != null)
			{
				users.Remove(currentUser);
			}

			return RedirectToAction("Index");
		}

		public ActionResult Save(UserViewModel userModel)
		{
			if (userModel != null)
			{
				if (userModel.Id == default(int))
				{
					// add
					users.Add(userModel.ToUser());
				}
				else
				{
					// update
					var currentUser = users.FirstOrDefault(u => u.Id == userModel.Id);
					if (currentUser != null)
					{
						var user = userModel.ToUser();
						currentUser.FirstName = user.FirstName;
						currentUser.LastName = user.LastName;
                        currentUser.Birth = user.Birth;
                        currentUser.Rewards = user.Rewards;
					}
				}
			}

			return RedirectToAction("Index");
		}
	}
}