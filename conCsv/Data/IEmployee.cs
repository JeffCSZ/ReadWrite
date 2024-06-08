using System;
using conCsv.Model;

namespace conCsv.Data
{
	public interface IEmployee
	{
		public IEnumerable<Employee> GetEmployees(); 

		public void AddEmployee(Employee employee); 
	}
}

