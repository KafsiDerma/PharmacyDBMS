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
        public float discount { get; set; }
        [Range(0, float.MaxValue)]
        public float price { get; set; }





    }
}
