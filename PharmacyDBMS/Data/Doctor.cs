using System.ComponentModel.DataAnnotations;

namespace PharmacyDBMS.Data
{
    public class Doctor
    {
        [Key]
        public int Medical_License { get; set; }

        public string name { get; set; }
        public int? phoneNumber { get; set; }
        public string? email { get; set; }


    }
}
