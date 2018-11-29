using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Department.DAL
{
	public class EmployeeDAO : IEmployeeDAO
	{
		private List<Employee> employees = new List<Employee>();
        public IEnumerable<Employee> InitList()
        {
            Add(new Employee()
            {
                LastName = "Иванов ",
                FirstName = "И.И.",
                Birth = new DateTime(2000, 12, 12),
          //      Rewards = "Награда1",
                Rewards = new List<Reward> {  }
            });
            Add(new Employee()
            {
                LastName = "Петров ",
                FirstName = "И.И.",
                Birth = DateTime.Now,
            //    Rewards = null,
                Rewards = new List<Reward> { }
            });
            Add(new Employee()
            {
                LastName = "Никитин ",
                FirstName = "И.И.",
                Birth = DateTime.Now,
           //     Rewards = null,
                Rewards = new List<Reward> { }
            });
            return GetList();
        }

        public void Add(Employee employee)
		{
			if (employee == null)
				throw new ArgumentException("пользователь");
            employee.ID = Math.Abs(GetHashCode());
            employees.Add(employee);
        }

		public IEnumerable<Employee> GetList()
		{
			return employees;
		}

        public void Remove(Employee employee)
        {
            if (employee == null)
                throw new ArgumentException("пользователь");

            employees.Remove(employee);
        }

        public void Edit(Employee employee)
        {

        }
    }

	
}
