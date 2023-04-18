using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyDBMS.Data
{
    public class Supplier
    {
        [Key]
        public int BusinessID { get; set; }
        public string BusinessName { get; set; }
        [ForeignKey("Product")]
        public int productID { get; set; }
        public int phonenumber { get; set; }

       
    }
}
