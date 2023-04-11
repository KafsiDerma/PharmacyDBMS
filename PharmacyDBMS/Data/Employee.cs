using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyDBMS.Data
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string HashedPassword { get; set; }
        [Required(AllowEmptyStrings = true)]
        [StringLength(10)]
        public string? PhoneNumber { get; set; }
        public float Salary { get; set; }
        public int Position { get; set; }
        public string? supervisor { get; set; }



    }
}
