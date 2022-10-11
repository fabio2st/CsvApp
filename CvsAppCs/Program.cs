using CsvAppCs;

CsvService csvService = new CsvService();
List<Product> products = csvService.ReadCsv<Product, ProductMap>("..\\..\\..\\..\\data\\product.csv");
foreach (var item in products)
{
    Console.WriteLine($"{item.ItemId} - {item.Location} - {item.Timestamp} - {item.Price} - {item.PromotionApplie}");
}