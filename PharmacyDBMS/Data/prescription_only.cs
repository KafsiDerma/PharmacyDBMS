using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyDBMS.Data
{
    public class prescription_only
    {
        [Key]
        
        public int id { get; set; }

        public String Scientific_Name { get; set; }

        public String Guide { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        
    }
}
