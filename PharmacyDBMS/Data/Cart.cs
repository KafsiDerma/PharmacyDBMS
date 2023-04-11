using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyDBMS.Data
{
    public class Cart
    {

        [Key]
        public int Id { get; set; }
        public float total_price { get; set; }
        [ForeignKey("Patient")]
        public int healthcardnum { get; set; }
        [ForeignKey("Employee")]
        public int Cashierid { get; set; }
        public string Receipt { get; set; }

    }
}
