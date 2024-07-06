using System.ComponentModel.DataAnnotations;

namespace DemoAPI.Controllers.Models.Entites
{
    public class Employees
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Phone { get; set; }
        [Required]
        public string Salary { get; set; }

    }
}
