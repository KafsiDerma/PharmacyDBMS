using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyDBMS.Data
{
    public class Prescription
    {
        [Key]
        public int prescriptionNum { get; set; }
        [Range(typeof(DateTime), "1/1/1753", "12/31/2022")]
        public DateTime IssueDate { get; set; }
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorMLNum { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
    }
}
