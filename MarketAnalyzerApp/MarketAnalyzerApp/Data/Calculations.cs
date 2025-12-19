using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAnalyzerApp.Data
{
    public static class Calculations
    {
        public static decimal? ConvertToDecimal(string priceString)
        {
            if (decimal.TryParse(priceString, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price))
            {
                return price;
            }
            else { return null; }
           
        }
    }
}
