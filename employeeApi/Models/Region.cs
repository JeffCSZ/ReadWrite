using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace employeeApi.Models
{
    public class Region
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }
        [Column("Region", TypeName = "varchar(100)")]
        public string RegionName { get; set; }
    }
}
