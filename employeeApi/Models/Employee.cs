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
        [Column(name: "Department", TypeName = "varchar(256)")]
        public string Department { get; set; }
        [Column(name: "State", TypeName = "varchar(256)")]
        public string State { get; set; }
        [Column(name: "Region", TypeName = "varchar(256)")]
        public string Region { get; set; }
        [Column(name: "Location", TypeName = "varchar(256)")]
        public string Location { get; set; }
    }
}
