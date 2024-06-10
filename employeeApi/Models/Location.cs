using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace employeeApi.Models
{
    public class Location
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }
        [Column("Location", TypeName = "varchar(100)")]
        public string LocationName { get; set; }
    }
}
