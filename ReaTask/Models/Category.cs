using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReaTask.Models
{
    [Table("Category")]
    public class Category
    {
        [Key, Required]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
