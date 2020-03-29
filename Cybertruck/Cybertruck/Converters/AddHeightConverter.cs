using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Cybertruck.Converters
{
    public class AddHeightConverter : IValueConverter
    {
        public object Convert(object containerHeight, Type targetType, object differnce, CultureInfo culture)
        {
            if (containerHeight != null)
            {
                if (containerHeight is double)
                {
                    var containerH = System.Convert.ToDouble(containerHeight);
                    var differnceH = System.Convert.ToDouble(differnce);
                    if (containerH > 0)
                    {
                        var result = containerH + differnceH;
                        return result;
                    }
                }
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
