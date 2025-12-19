using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAnalyzerApp.Data
{
    public class CSVDataLoader
    {
        private static string datasetPath = Path.Combine(Application.StartupPath, "Data\\amazon_small_dataset.csv");
        private const int dataLimit = 80000;

        public static List<Product> LoadData()
        {
            List<Product> products = new List<Product>();
            using (var reader = new StreamReader(datasetPath))
            using (var csv = new CsvHelper.CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ProductMap>();
                products = csv.GetRecords<Product>().Take(dataLimit).ToList();
            }
            return products;
        }
    }
}
