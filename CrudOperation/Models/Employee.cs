using System.ComponentModel.DataAnnotations;

namespace CrudOperation.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
    }
}
