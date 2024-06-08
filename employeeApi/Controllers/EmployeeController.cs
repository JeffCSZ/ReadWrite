using employeeApi.Data;
using employeeApi.Models;
using employeeApi.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace employeeApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController(IEmployeeRepo _repo) : ControllerBase
	{

		[HttpGet("ClearAllEmployee")]
		public ActionResult ClearAllEmployee()
		{
			_repo.ClearAllEmployees();
			return Ok("All Employees Cleared");
		}

		[HttpGet("SetAllEmployeesFromCSV")]
		public ActionResult SetAllEmployeesFromCSV()
		{
			_repo.AllEmployeesFromCSV();
			return Ok("All Employees Set");
		}

		[HttpGet("GetAllEmployees")]
		public ActionResult<List<Employee>> GetAllEmployees()
		{
			return Ok(_repo.GetAllEmployees());
		}

		[HttpGet("GetEmployeeById/{id}")]
		public ActionResult<Employee> GetEmployeeById(int id)
		{
			var e = _repo.GetEmployeeById(id);
			if (e == null)
			{
				return NotFound();
			}
			return Ok(e);
		}

		[HttpPost]
		public ActionResult<Employee> AddEmployee(Employee e)
		{
			//_repo.AddEmployee(e);
			return CreatedAtAction(nameof(GetEmployeeById), new { id = e.Id }, e);
		}

		[HttpPost("UploadCSVFile")]
		public ActionResult Upload(IFormFile file)
		{
			if (file == null || file.Length == 0)
				return BadRequest("No file uploaded.");

			byte[] Data;

			using (var memoryStream = new MemoryStream())
			{
				file.CopyTo(memoryStream);
				Data = memoryStream.ToArray();
			}

			var stringData = System.Text.Encoding.UTF8.GetString(Data);
            
			if (_repo.SetAllEmployeesFromString(stringData))
			{
				return Ok("All Employees Set");
			}
			return BadRequest("Incorrect file format!");

        }

		
	}
}
