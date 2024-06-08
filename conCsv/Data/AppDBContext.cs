using System;
using conCsv.Model;
using Microsoft.EntityFrameworkCore;

namespace conCsv.Data
{
	public class AppDBContext : DbContext
	{

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
             options.UseInMemoryDatabase("TestDb");
        }


        public DbSet<Employee> employees { get; set; }
		
	}
}

