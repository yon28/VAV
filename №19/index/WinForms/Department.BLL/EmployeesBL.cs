using Department.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Department.BLL
{
    public class EmployeesBL
    {
		private readonly IEmployeeDAO employeesDAO;
		public EmployeesBL()
		{
		     // employeesDAO = new EmployeeDAO();
			  employeesDAO = new EmployeeDAOdb();
		}
		public IEnumerable<Employee> InitList()
        {
            return employeesDAO.InitList();
        }
     
		public IEnumerable<Employee> SortByLastName( string ascendingORdescending)
		{
            IEnumerable<Employee> employees;
            if (ascendingORdescending == "ascending")
            {
                employees = (from s in GetList()
                             orderby s.LastName ascending
                             select s).ToList();
            }
            else
            {
                employees = (from s in GetList()
                             orderby s.LastName descending
                             select s).ToList();
            }
            foreach (Employee employee in employeesDAO.GetList())
            {
                Remove(employee);
            }
            foreach (Employee employee in employees)
            {
                Add(employee);
            }
            return employees;
        }


		public void Add(string lastName, string firstName, DateTime birth, List<Reward> rewards)
		{
            Employee employee = new Employee
			{
                FirstName = firstName,
                LastName = lastName,
                Birth = birth,
                Rewards = rewards
            };
			this.Add(employee);
		}

		public void Add(Employee employee)
		{
			if (employee == null)
				throw new ArgumentException("пользователь");
			employeesDAO.Add(employee);
		}

        public void Remove(string lastName, string firstName, DateTime birth, List<Reward> rewards)
        {
            Employee employee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Birth = birth,
                Rewards = rewards
            };

            this.Remove(employee);
        }

        public void Remove(Employee employee)
        {
            if (employee == null)
                throw new ArgumentException("пользователь");
            employeesDAO.Remove(employee);
        }

        public IEnumerable<Employee> GetList()
		{
			return employeesDAO.GetList();
		}

        public void Edit(string lastName, string firstName, DateTime birth, List<Reward> rewards)
        {
            Employee employee = new Employee
            {
                LastName = lastName,
                FirstName = firstName,
                Birth =  birth,
                Rewards = rewards
            };
            this.Edit(employee);
        }

        public void Edit(Employee employee)
        {
            if (employee == null)
                throw new ArgumentException("пользователь");
            employeesDAO.Edit(employee);
        }
    }
}
