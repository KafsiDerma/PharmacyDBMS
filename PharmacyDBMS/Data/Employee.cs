using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PharmacyDBMS.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string HashedPassword { get; set; }
        public int? PhoneNumber { get; set; }
        public float Salary { get; set; }
        public int Position { get; set; }
        public string? supervisor { get; set; }



    }
}
