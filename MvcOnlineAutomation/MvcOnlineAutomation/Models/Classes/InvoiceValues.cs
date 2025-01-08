using System.ComponentModel.DataAnnotations;

namespace MvcOnlineAutomation.Models.Classes
{
    public class InvoiceValues
    {
        [Key]
        public int InvoiceItemId { get; set; } // Fatura Kalem ID
        public string InvoiceItemDescription { get; set; } // Açıklama
        public int InvoiceItemQuantity { get; set; } // Miktar
        public decimal InvoiceItemUnitPrice { get; set; } // Birim Fiyat
        public decimal InvoiceItemTotal { get; set; } // Tutar
    }
}
