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
			employeesDAO = new EmployeeDAO();
            //employeesDAO = new EmployeeDAOdb();
        }
        public IEnumerable<Employee> InitList()
        {
            return employeesDAO.InitList();
        }
        //
        //Наградить 
        public IEnumerable<Employee> SortEmployeesByFullNameAsc()
		{
			return (from s in GetList()
						orderby s.LastName ascending
						select s);
		}

		public IEnumerable<Employee> SortEmployeesByFullNameDesc()
		{
			return (from s in GetList()
						orderby s.LastName descending
						select s).ToList();
		}

		public void Add(string lastName, string firstName, int birth, string rewardE)
		{
			Employee employee = new Employee
			{
                FirstName = firstName,
                LastName = lastName,
                Birth = birth,
                RewardE = rewardE
            };

			this.Add(employee);
		}

		public void Add(Employee employee)
		{
			if (employee == null)
				throw new ArgumentException("пользователь");

			employeesDAO.Add(employee);
		}

        public void Remove(string lastName, string firstName, int birth, string rewardE)
        {
            Employee employee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Birth = birth,
                RewardE = rewardE
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
    }
}
