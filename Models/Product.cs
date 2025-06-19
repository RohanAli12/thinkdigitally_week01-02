using System.ComponentModel.DataAnnotations;

namespace Think_Digitally_week01.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
    }
}
