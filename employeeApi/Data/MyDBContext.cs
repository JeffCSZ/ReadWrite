using employeeApi.Models;
using employeeApi.Utils;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace employeeApi.Data
{
	public class MyDBContext(DbContextOptions<MyDBContext> options) : DbContext(options)
	{

		//SeedData
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			
		
		   var employees = new ReadData().ReadALlData().employees;
			int Id = 0;
			modelBuilder.Entity<Employee>().HasData(
				employees.Select(e => new Employee { Id=++Id, FullName = e }).ToArray()
			);
		}
		public DbSet<Employee> Employees { get; set; }

		public DbSet<Department> Departments { get; set; }

	}
}
