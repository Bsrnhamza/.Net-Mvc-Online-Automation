using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.Classes
{
    public class InvoiceValue //FaturaKalem
    {
        [Key]
        public int InvoiceItemId { get; set; } // Fatura Kalem ID
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string InvoiceItemDescription { get; set; } // Açıklama
        public int InvoiceItemQuantity { get; set; } // Miktar
        public decimal InvoiceItemUnitPrice { get; set; } // Birim Fiyat
        public decimal InvoiceItemTotal { get; set; } // Tutar

        public virtual Invoice Invoice { get; set; }
    }
}
