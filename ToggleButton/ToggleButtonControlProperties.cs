using System.Windows;

namespace ToggleButton
{
    public partial class ToggleButtonControl
    {
        public static readonly DependencyProperty IsCheckedProperty =
        DependencyProperty.Register(
            name: "IsChecked",
            propertyType: typeof(bool),
            ownerType: typeof(ToggleButtonControl),
            typeMetadata: new FrameworkPropertyMetadata(defaultValue: false));
        public bool IsChecked
        {
            get => (bool)GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }
    }
}
