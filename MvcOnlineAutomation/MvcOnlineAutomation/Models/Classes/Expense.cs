using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Expense //Giderler
    {
        [Key]
        public int ExpenseId { get; set; } // Gider ID
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string ExpenseDescription { get; set; } // Açıklama
        public DateTime ExpenseDate { get; set; } // Tarih
        public decimal ExpenseAmount { get; set; } // Tutar
    }
}
