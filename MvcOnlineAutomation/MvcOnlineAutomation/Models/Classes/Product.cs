using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Product //ürün
    {
        [Key]
        public int ProductId { get; set; }       // Ürün ID'si
        [Column(TypeName ="Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }       // Ürün adı
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductBrand { get; set; }        // Ürün markası
        public short ProductStock { get; set; }        // Ürün stok miktarı
        public decimal ProductPurchasePrice { get; set; }        // Ürün alış fiyatı
        public decimal ProductSalesPrice { get; set; }       // Ürün satış fiyatı
        public bool ProductStatus { get; set; }        // Ürün durumu 
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string ProductImage { get; set; }        // Ürün görseli

        public virtual Category Category { get; set; }
        public ICollection<SalesTransaction> SalesTransactions { get; set; }
    }
}
