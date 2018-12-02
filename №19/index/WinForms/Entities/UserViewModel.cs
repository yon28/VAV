using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities
{
    public class UserViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public byte Age { get; set; }
        public List<Reward> Rewards { get; set; }
        public List<RewardViewModel> AvailableRewards { get; set; }

        public Employee ToUser()
        {
            return new Employee
            {
                ID = ID,
                FirstName = FirstName,
                LastName = LastName,
                Birth = Birth,
                Rewards = AvailableRewards
                    .Where(r => r.Checked == true)
                    .Select(r => new Reward
                    {
                        ID = r.ID,
                        Title = r.Title,
                        Description = r.Description
                    }).ToList()
            };
        }

        public static UserViewModel GetViewModel(Employee employee, List<Reward> availableRewards)
        {
            var employeemodel = new UserViewModel();
            employeemodel.ID = employee.ID;
            employeemodel.FirstName = employee.FirstName;
            employeemodel.LastName = employee.LastName;
            employeemodel.Birth = employee.Birth;
            employeemodel.Age = employee.Age;
            var rewards = new List<RewardViewModel>();
            foreach (var reward in availableRewards)
            {
                rewards.Add(RewardViewModel.GetViewModel(reward, employee.Rewards));
            }
            employeemodel.AvailableRewards = rewards.ToList();
            return employeemodel;
        }

		
	}
}
