using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyDBMS.Data
{
    public class Cart
    {

        [Key]
        public int Id { get; set; }
        public float total_price { get; set; }
        
        public Patient healthcardnum { get; set; }
        
        public Employee Cashierid { get; set; }
        public string Receipt { get; set; }

    }
}
