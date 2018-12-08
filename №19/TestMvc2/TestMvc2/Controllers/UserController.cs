using Department.BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
//using TestMvc2.Models;

namespace TestMvc2.Controllers
{
    public class UserController : Controller
    {
        EmployeesBL employeesBL;
        RewardsBL rewardsBL;

        //private static List<Employee> users = new List<Employee>
        //{
        //    new Employee { ID = 1, FirstName = "first user", LastName = "first userovich", Birth = new DateTime(1981, 10, 10), Rewards = new List<Reward> { /*rewards[2]*/ } },
        //    new Employee { ID = 2, FirstName = "second user", LastName = "second userovich", Birth = new DateTime(1982, 10, 10), Rewards = new List<Reward> { /*rewards[1], rewards[2] */} },
        //    new Employee { ID = 3, FirstName = "third user", LastName = "third userovich", Birth = new DateTime(1983, 10, 10)}
        //};

        public UserController()
        {
            employeesBL = Wrapper.employeesBL;
            rewardsBL = Wrapper.rewardsBL;
        }

        public ActionResult Index()
        {
            return View(employeesBL.GetList());
        }

        public ActionResult Edit(int userId)
        {
            var rewards = rewardsBL;
            var currentUser = employeesBL.GetList().FirstOrDefault(u => u.ID == userId);
            return View(UserViewModel.GetViewModel(currentUser, rewards.GetList()));
        }

        public ActionResult Add()
        {
            var rewards = new List<RewardViewModel>();
            foreach (var reward in rewardsBL.GetList())
            {
                rewards.Add(RewardViewModel.GetViewModel(reward, null));
            }
            return View("Edit", new UserViewModel() { AvailableRewards = rewards });
        }

        public ActionResult Cancel()
        {
            return View("Cancel");
        }

        public ActionResult Del()
        {
            return View("Del");
        }

        public ActionResult Delete(int userId)
        {
            var users = employeesBL.GetList();
            var currentUser = users.FirstOrDefault(u => u.ID == userId);
            if (currentUser != null)
            {
                employeesBL.Remove(currentUser);

            }
            return RedirectToAction("Index");
        }

        public ActionResult Save(UserViewModel userModel)
        {
            if (userModel != null)
            {
                if (userModel.ID == default(int))
                {
                    // add

                    employeesBL.Add(userModel.ToUser());
                }
                else
                {
                    // update
                    var currentUser = employeesBL.GetList().FirstOrDefault(u => u.ID == userModel.ID);
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