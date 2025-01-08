using System.ComponentModel.DataAnnotations;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }       // Ürün ID'si
        public string ProductName { get; set; }       // Ürün adı
        public string ProductBrand { get; set; }        // Ürün markası
        public short ProductStock { get; set; }        // Ürün stok miktarı
        public decimal ProductPurchasePrice { get; set; }        // Ürün alış fiyatı
        public decimal ProductSalesPrice { get; set; }       // Ürün satış fiyatı
        public bool ProductStatus { get; set; }        // Ürün durumu 
        public string ProductImage { get; set; }        // Ürün görseli
    }
}
