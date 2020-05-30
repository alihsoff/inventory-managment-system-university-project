using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Util
{
    class CurrencyConverter
    {
        public static String toAzn(Decimal baseValue, Decimal fromValue)
        {
            NumberFormatInfo setPrecision = new NumberFormatInfo();
            setPrecision.NumberDecimalDigits = 4;
            decimal result = baseValue / fromValue;
            return result.ToString("N", setPrecision);
        }

        public static decimal toAzn(String baseCurrency, Decimal fromValue)
        {
            NumberFormatInfo setPrecision = new NumberFormatInfo();
            setPrecision.NumberDecimalDigits = 4;
            if (baseCurrency.Equals("EUR"))
            {
                return (decimal.Parse(1.85.ToString()) * fromValue);
            } 
            else if (baseCurrency.Equals("USD"))
            {
                return (decimal.Parse(1.7.ToString()) * fromValue);
            }
            else if (baseCurrency.Equals("RUB"))
            {
                return (decimal.Parse(0.023.ToString()) * fromValue);
            }
            return (decimal.Parse(0.25.ToString()) * fromValue);

        }
    }
}
