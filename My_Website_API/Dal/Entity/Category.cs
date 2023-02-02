using System.ComponentModel.DataAnnotations;

namespace My_Website_API.Dal.Entity
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }     
        public string CategoryName { get; set; }
    }
}
