using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace INaBit.Converter
{
    public class RecommandConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if((int)value == 1)
            {
                return new BitmapImage(new Uri("/아이콘/three_heart.png", UriKind.Relative));
            }
            if ((int)value == 2)
            {
                return new BitmapImage(new Uri("/아이콘/two_heart.png", UriKind.Relative));
            }
            if ((int)value == 3)
            {
                return new BitmapImage(new Uri("/아이콘/one_heart.png", UriKind.Relative));
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
