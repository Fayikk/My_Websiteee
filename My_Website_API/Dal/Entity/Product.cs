using System.ComponentModel.DataAnnotations;

namespace My_Website_API.Dal.Entity
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } 
    }
}
