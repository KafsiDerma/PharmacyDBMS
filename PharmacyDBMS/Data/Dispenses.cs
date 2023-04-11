using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyDBMS.Data
{
    [PrimaryKey("CartID","ProductID","PharmacistID")]
    public class Dispenses
    {
        
        [ForeignKey("Cart")]
        public int CartID { get; set; }
        
        [ForeignKey("Product")]
        public string ProductID { get; set;}
        
        [ForeignKey("Employee")]
        public int PharmacistID { get; set; }
    }
}
