using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employeeApi.Models
{
	[Table("Employees")]
	public class Employee
	{
		[Column("Id")]
		[Key]
        public int Id { get; set; }

		[Column(name: "FullName", TypeName = "varchar(256)")]
		public string FullName { get; set; }
    }
}
