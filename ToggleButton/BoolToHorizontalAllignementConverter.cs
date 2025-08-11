using System.Windows;
using System.Windows.Data;
using System.Globalization;

namespace ToggleButton
{
    internal class BoolToHorizontalAllignementConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool currentValue = (bool)value;
            return currentValue ? HorizontalAlignment.Right : HorizontalAlignment.Left;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            HorizontalAlignment currentValue = (HorizontalAlignment)value;
            return currentValue == HorizontalAlignment.Left ? false : true;
        }
    }
}
