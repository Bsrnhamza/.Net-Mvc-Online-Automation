using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; } // Admin'in benzersiz ID'si
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string AdminName { get; set; } // Admin'in adı
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string AdminPassword { get; set; } // Admin'in şifresi
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string AdminAuthorization { get; set; } // Admin'in yetkilendirme seviyesi

    }
}
