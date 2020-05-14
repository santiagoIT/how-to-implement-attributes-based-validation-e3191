using System;
using System.Globalization;
using System.Windows.Data;

namespace DXGrid_AttributesBasedValidation
{
  public class UnitConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value is double)
      {
        var d = (double)value;
        return d*1000;
      }

      return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value is string strValue)
      {
        if (double.TryParse(strValue, out var doubleResult))
        {
          return doubleResult / 1000;
        }
      }

      if (value is decimal doubleValue)
      {
        return doubleValue / 1000;
      }

      return value;
    }
  }
}
