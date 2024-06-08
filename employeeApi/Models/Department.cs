using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employeeApi.Models
{
	public class Department
	{
		[Column("Id")]
		[Key]
		public int Id { get; set; }
		[Column("Dept", TypeName = "varchar(100)")]
		public string DepartmentName { get; set; }
    }
}
