using System.ComponentModel.DataAnnotations;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Invoices
    {
        [Key]
        public int InvoiceId { get; set; } // Fatura ID
        public string SerialNumber { get; set; } // Seri Numara
        public int SequenceNumber { get; set; } // Sıra Numara
        public DateTime Date { get; set; } // Tarih
        public string TaxOffice { get; set; } // Vergi Dairesi
        public TimeSpan Time { get; set; } // Saat
        public string DeliveredBy { get; set; } // Teslim Eden
        public string ReceivedBy { get; set; } // Teslim Alan
    }

}
}
