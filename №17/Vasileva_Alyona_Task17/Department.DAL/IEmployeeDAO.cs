using System;
using System.Collections.Generic;
using Entities;

namespace Department.DAL
{
	public interface IEmployeeDAO
	{
		void Add(Employee employee);
        IEnumerable<Employee> GetList();
        void Remove(Employee employee);
        IEnumerable<Employee> InitList();
        void Edit(Employee employee);
    }
}
