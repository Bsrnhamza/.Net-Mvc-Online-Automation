using System.ComponentModel.DataAnnotations;

namespace MvcOnlineAutomation.Models.Classes
{
    public class SalesTransaction
    {
        [Key]
        public int TransactionId { get; set; } // Satış ID
        public DateTime TransactionDate { get; set; } // Tarih
        public int TransactionQuantity { get; set; } // Adet
        public decimal TransactionPrice { get; set; } // Fiyat
        public decimal TransactionTotalAmount { get; set; } // Toplam Tutar

        public virtual Product Products { get; set; }
        public virtual Current Currents { get; set; }
        public virtual Personnel Personnels { get; set; }
    }
}
