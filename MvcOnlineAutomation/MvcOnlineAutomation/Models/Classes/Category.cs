using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; } // Kategorinin benzersiz ID'si
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CategoryName { get; set; } // Kategorinin adı

        public ICollection<Product> Products { get; set; }
    }
}
