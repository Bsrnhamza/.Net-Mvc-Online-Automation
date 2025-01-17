using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Invoice //Fatura
    {
        [Key]
        public int InvoiceId { get; set; } // Fatura ID
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string InvoiceSerialNumber { get; set; } // Seri Numara
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public int InvoiceSequenceNumber { get; set; } // Sıra Numara
        public DateTime InvoiceDate { get; set; } // Tarih
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string InvoiceTaxOffice { get; set; } // Vergi Dairesi
        public TimeSpan InvoiceTime { get; set; } // Saat
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string InvoiceDeliveredBy { get; set; } // Teslim Eden
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string InvoiceReceivedBy { get; set; } // Teslim Alan

        public ICollection<InvoiceValue> InvoiceValues  { get; set; }
    }
}
