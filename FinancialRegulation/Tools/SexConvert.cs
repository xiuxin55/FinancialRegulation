using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
namespace FinancialRegulation.Tools
{
    public class SexConvert : IValueConverter
    {
       public  object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value ==null || value.ToString()=="男")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       public object  ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
