using employeeApi.Data;
using employeeApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace employeeApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DepartmentController (IDepartmentRepo _departmentRepo) : ControllerBase
	{
		[HttpGet]
		public ActionResult<List<Department>> GetDepartments()
		{
			var d = _departmentRepo.GetDepartments();
			return Ok(d);
		}
	}
}
