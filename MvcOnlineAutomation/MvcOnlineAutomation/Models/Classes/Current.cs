using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Current // cariler
    {
        [Key]
        public int CurrentId { get; set; } // Mevcut kullanıcının benzersiz ID'si
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CurrentName { get; set; } // Mevcut kullanıcının adı
        [Column(TypeName = "Varchar")]
        [StringLength(30)] 
        public string CurrentSurname { get; set; } // Mevcut kullanıcının soyadı
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string CurrentCity { get; set; } // Mevcut kullanıcının şehri
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CurrentEmail { get; set; } // Mevcut kullanıcının e-posta adresi

        public ICollection<SalesTransaction> SalesTransactions { get; set; }


    }
}
