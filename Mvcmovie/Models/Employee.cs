using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvcmovie.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set;}
        public string Name { get; set;}
        public string SDT { get; set;}
         public string Age { get; set;}
    }
}