using employeeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace employeeApi.Data
{
	public interface IDepartmentRepo
	{
		List<Department> GetDepartments();
	}
}
