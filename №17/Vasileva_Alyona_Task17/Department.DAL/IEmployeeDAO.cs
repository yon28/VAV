using System;
using System.Collections.Generic;
using Entities;

namespace Department.DAL
{
	public interface IEmployeeDAO
	{
		void Add(Entities.Employee employee);
		System.Collections.Generic.IEnumerable<Entities.Employee> GetList();
        void Remove(Employee employee);
        IEnumerable<Employee> InitList();
    }
}
