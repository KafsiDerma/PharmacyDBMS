using System.ComponentModel.DataAnnotations;

namespace PharmacyDBMS.Data
{
    public class Product
    {
        [Key]
        public int productID {  get; set; }
        public string name { get; set; }
        [Range(0, int.MaxValue)]
        public int stockAmount { get; set; }
        [Range(0.0, 1.0)]
        public double discount { get; set; }  // starts off as 1, basically gets multiplied by price to get the discount
        [Range(0, double.MaxValue)]
        public double price { get; set; }

        
        public Supplier Supplier { get; set; }



    }
}
