using employeeApi.Models;
using employeeApi.Utils;
using Microsoft.EntityFrameworkCore;

namespace employeeApi.Data
{
	public class EmployeeRepo(MyDBContext _db) : IEmployeeRepo
	{

		public bool SetAllEmployeesFromString(string data)
		{
			try
			{
				
				if (_db.Employees.Count() > 0)
				{
					ClearAllEmployees();
				}


				var employees= new ReadData().ReadALlDataFromString(data).employees;
				foreach (var e in employees)
				{
					_db.Employees.Add(new Employee { FullName = e });
				}

				_db.SaveChanges();
				return true;

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return false;
			}
		}
		public void AllEmployeesFromCSV()
		{
			if (_db.Employees.Count() > 0)
			{
				ClearAllEmployees();
				
			}
			
			 var employees= new ReadData().ReadALlData().employees;
			foreach (var e in employees)
			{
				_db.Employees.Add(new Employee { FullName = e });
			}
			_db.SaveChanges();
		}

		public void ClearAllEmployees()
		{
			//foreach (var r in _db.Employees)
			//{
			//	_db.Employees.Remove(r);
			//	_db.SaveChanges();
			//}

			//TCN: you can write direct SQL statement
			_db.Database.ExecuteSqlRaw("TRUNCATE TABLE Employees");
			
   
		}

		public IEnumerable<Employee> GetAllEmployees()
		{
			return _db.Employees;
		}

		public Employee GetEmployeeById(int id)
		{
			return _db.Employees.FirstOrDefault(e => e.Id == id);
		
		}

		
	}
}
