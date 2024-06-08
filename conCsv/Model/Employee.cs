using System;
using System.ComponentModel.DataAnnotations;

namespace conCsv.Model
{
	public class Employee
	{

		public Employee(string name)
		{
			Name = name;
		}
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
	}
}

