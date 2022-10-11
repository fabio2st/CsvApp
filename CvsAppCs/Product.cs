using CsvHelper.Configuration.Attributes;
using CsvHelper.Configuration;

namespace CsvAppCs
{
    public class Product
    {
        public string ItemId { get; set; }
        public string Location { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Price { get; set; }
        public bool PromotionApplie { get; set; }
    }
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            string format = "yyyyMMdd";
            Map(m => m.ItemId).Name("�tem_id");
            Map(m => m.Location).Name("location");
            Map(m => m.Timestamp).TypeConverterOption.Format(format).Name("timestamp");
            Map(m => m.Price).Name("price");
            Map(m => m.PromotionApplie).Name("promapplie");
        }
    }
}