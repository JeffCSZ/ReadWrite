using employeeApi.Models;
using employeeApi.Utils;

namespace employeeApi.Data
{
	public class DepartmentRepo(MyDBContext _dbContext) : IDepartmentRepo
	{
		public List<Department> GetDepartments()
		{
			var reader = new ReadData();
		    var departmentString = reader.GetDepartments("TestData.csv");
			foreach (var d in departmentString)
			{
				_dbContext.Departments.Add(new Department() {DepartmentName = d } );
			}
			_dbContext.SaveChanges(); 
			return _dbContext.Departments.ToList();
		}
	}
}
