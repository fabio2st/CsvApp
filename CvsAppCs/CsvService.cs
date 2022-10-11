using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;

namespace CsvAppCs
{
    public class CsvService
    {
        public List<T> ReadCsv<T,TMap>(string fullPath) where TMap : ClassMap<T>
        {
            var config = new CsvConfiguration(CultureInfo.CurrentCulture) { Delimiter = ";" };
            using (StreamReader reader = new StreamReader(fullPath, Encoding.UTF8))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<TMap>();
                return csv.GetRecords<T>().ToList();
            }
        }
    }
}