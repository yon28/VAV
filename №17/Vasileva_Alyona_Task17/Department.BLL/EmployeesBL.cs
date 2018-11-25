﻿using Department.DAL;
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
		  //   employeesDAO = new EmployeeDAO();
          	 employeesDAO = new EmployeeDAOdb();
        }
        public IEnumerable<Employee> InitList()
        {
            return employeesDAO.InitList();
        }
        //
     
        public IEnumerable<Employee> SortEmployeesByLastNameAsc()
		{
			return (from s in GetList()
						orderby s.LastName ascending
						select s);
		}

		public IEnumerable<Employee> SortEmployeesByLastNameDesc()
		{
			return (from s in GetList()
						orderby s.LastName descending
						select s).ToList();
		}

		public void Add(string lastName, string firstName, DateTime birth, string rewards, List<int> rewardsIdList)
		{

            Employee employee = new Employee
			{
                FirstName = firstName,
                LastName = lastName,
                Birth = birth,
                Rewards = rewards,
                RewardsIdList = rewardsIdList
            };

			this.Add(employee);
		}

		public void Add(Employee employee)
		{
			if (employee == null)
				throw new ArgumentException("пользователь");
			employeesDAO.Add(employee);
		}

        public void Remove(string lastName, string firstName, DateTime birth, string rewards, List<int> rewardsIdList)
        {
            Employee employee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Birth = birth,
                Rewards = rewards,
                RewardsIdList = rewardsIdList
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

        public void Edit(string lastName, string firstName, DateTime birth, string rewards, List<int> rewardsIdList)
        {
            Employee employee = new Employee
            {
                LastName = lastName,
                FirstName = firstName,
                Birth =  birth,
                Rewards = rewards,
                RewardsIdList = rewardsIdList
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
