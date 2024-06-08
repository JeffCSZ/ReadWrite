using employeeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace employeeApi.Data
{
	public interface IEmployeeRepo
	{
		void ClearAllEmployees();

		IEnumerable<Employee> GetAllEmployees();

		Employee GetEmployeeById(int id);

		void AllEmployeesFromCSV();

		bool SetAllEmployeesFromString(string data);
	}

}
