using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReaTask.Models
{
    [Table("Product")]
    public class Product
    {
        [Key, Required]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsNew { get; set; }
        public decimal Price { get; set; }
        public virtual Category? Category { get; set; }
    }
}
