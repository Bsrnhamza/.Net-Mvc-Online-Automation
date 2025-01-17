using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Personnel
    {
        [Key]
        public int PersonnelId { get; set; } // Personelin benzersiz ID'si
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string PersonnelName { get; set; } // Personelin adı
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string PersonnelSurname { get; set; } // Personelin soyadı
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string PersonnelImg { get; set; } // Personelin profil resmi (görsel)

        public ICollection<SalesTransaction> SalesTransactions { get; set; }

        public virtual Department Department { get; set; }

    }
}
