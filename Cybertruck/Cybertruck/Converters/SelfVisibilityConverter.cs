using System;
using System.Globalization;
using Xamarin.Forms;

namespace Cybertruck.Converters
{
    public class SelfVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                if (value==null)
                {
                    return false;
                }
                if(value!=null && value.ToString() == string.Empty)
                {
                    return false;
                }
            }

            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
