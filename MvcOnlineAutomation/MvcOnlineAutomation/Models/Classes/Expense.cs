using System.ComponentModel.DataAnnotations;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; } // Gider ID
        public string ExpenseDescription { get; set; } // Açıklama
        public DateTime ExpenseDate { get; set; } // Tarih
        public decimal ExpenseAmount { get; set; } // Tutar
    }
}
