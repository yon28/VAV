using System;
using System.Collections.Generic;

namespace Entities
{
    public class EmployeeGridViewModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
      //  public List<Reward> Rewards { get; set; }
        public string Rewards { get; set; }
        public DateTime Birth { get; set; }
        public int ID { get; set; }
        public byte Age { get; set; }

        public static EmployeeGridViewModel CreateFromEmployee(Employee employee)
        {
            var model = new EmployeeGridViewModel();
            model.LastName = employee.LastName;
            model.FirstName = employee.FirstName;
            model.Birth = employee.Birth;
            model.ID = employee.ID;
            model.Age = employee.Age;
           
            if (employee.Rewards != null)/////
            {
               model.Rewards = string.Join(", ", employee.Rewards);
            }

            return model;
        }
    }
}
