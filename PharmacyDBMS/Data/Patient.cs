using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyDBMS.Data
{
    public class Patient
    {

        [Key]
        public int HealthCardNum { get; set; }
        public string PatientFullName { get; set; }
        public int PhoneNumber { get; set; }
        [ForeignKey("InsuranceAgency")]
        public int ID { get; set; }
    }
}
