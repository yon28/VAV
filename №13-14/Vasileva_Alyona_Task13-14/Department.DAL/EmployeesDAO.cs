using Entities;
using System;
using System.Collections.Generic;

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
                Birth = 1990,
                Rewards = "Награда1"
            });
            Add(new Employee()
            {
                LastName = "Петров ",
                FirstName = "И.И.",
                Birth = 1991,
                Rewards = null
            });
            Add(new Employee()
            {
                LastName = "Никитин ",
                FirstName = "И.И.",
                Birth = 1992,
                Rewards = null
            });

            return GetList();
        }

        public void Add(Employee employee)
		{
			if (employee == null)
				throw new ArgumentException("пользователь");

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
    }

	public class EmployeeDAOdb : IEmployeeDAO
	{
        public void Add(Employee employee)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Employee> GetList()
		{
			throw new NotImplementedException();
		}

        public IEnumerable<Employee> InitList()
        {
            throw new NotImplementedException();
        }

        public void Remove(Employee employee)
        {
            throw new NotImplementedException();
        }

    }
}
