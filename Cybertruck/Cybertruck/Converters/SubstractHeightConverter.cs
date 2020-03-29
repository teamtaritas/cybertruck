using System;
using System.Globalization;
using Xamarin.Forms;

namespace Cybertruck.Converters
{
    public class SubstractHeightConverter : IValueConverter
    {
        public object Convert(object containerHeight, Type targetType, object differnce, CultureInfo culture)
        {
            if (containerHeight!=null)
            {
                if (containerHeight is double)
                {
                    var containerH = System.Convert.ToDouble(containerHeight);
                    var differnceH = System.Convert.ToDouble(differnce);
                    if (containerH>0)
                    {
                        var result = containerH - differnceH;
                        return result; 
                    }
                }
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            throw new NotImplementedException();
        }
    }
}
