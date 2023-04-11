using System.ComponentModel.DataAnnotations;

namespace PharmacyDBMS.Data
{
    public class InsuranceAgency
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string? email { get; set; }



    }
}
