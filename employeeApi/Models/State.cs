using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace employeeApi.Models
{
    public class State
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }
        [Column("State", TypeName = "varchar(100)")]
        public string StateName { get; set; }
    }
}
