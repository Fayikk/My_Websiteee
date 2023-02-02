using System.ComponentModel.DataAnnotations;

namespace My_Website_API.Dal.Entity
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }

        public Product BuyProduct { get; set; }
    }
}
