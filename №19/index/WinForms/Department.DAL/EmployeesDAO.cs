using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Department.DAL
{
	public class EmployeeDAO : IEmployeeDAO
	{
		private List<Employee> employees = new List<Employee>();

        public IEnumerable<Employee> InitList()//
        {
            employees.Add(new Employee()
            {
                LastName = "Иванов ",
                FirstName = "И.И.",
                Birth = new DateTime(2000, 12, 12),
                ID = 1,
                Rewards = new List<Reward> { }
            });
            employees.Add(new Employee()
            {
                LastName = "Петров ",
                FirstName = "И.И.",
                ID = 2,
                Birth = DateTime.Now,
                Rewards = new List<Reward> { }
            });
            employees.Add(new Employee()
            {
                LastName = "Никитин ",
                FirstName = "И.И.",
                ID = 3,
                Birth = DateTime.Now,
                Rewards = new List<Reward> { }
            });
            return GetList();
        }

        public IEnumerable<Employee> GetList()
        {
            return employees;
        }

        public void Add(Employee employee)
		{
			if (employee == null)
				throw new ArgumentException("пользователь");
            employee.ID = Math.Abs(GetHashCode());
            employees.Add(employee);
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
