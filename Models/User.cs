using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_mvc_db_mysql_net6.Models
{
    [Table("User")]
    public class User
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Column("Name")]
        public string Name { get; set; }
    }
}
