using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace BeautifulWeather.Resources.Converters
{
    class WindDirectionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string resourceName;
            switch ((WindDirection)value)
            {
                case WindDirection.West:
                    resourceName = "wind_arrow_left";
                    break;

                case WindDirection.East:
                    resourceName = "wind_arrow_right";
                    break;

                case WindDirection.Nord:
                    resourceName = "wind_arrow_top";
                    break;

                case WindDirection.South:
                    resourceName = "wind_arrow_bottom";
                    break;

                default: return null;
            }

            return Application.Current.Resources[resourceName] as ControlTemplate;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
