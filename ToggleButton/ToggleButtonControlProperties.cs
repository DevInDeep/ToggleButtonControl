using System.Windows;
using System.Windows.Media;

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

        public static readonly DependencyProperty OnColorProperty =
        DependencyProperty.Register(
            name: "OnColor",
            propertyType: typeof(Color),
            ownerType: typeof(ToggleButtonControl),
            typeMetadata: new FrameworkPropertyMetadata(defaultValue: Colors.Gray));
        public Color OnColor
        {
            get => (Color)GetValue(OnColorProperty);
            set => SetValue(OnColorProperty, value);
        }

        public static readonly DependencyProperty OnTextProperty =
        DependencyProperty.Register(
            name: "OnText",
            propertyType: typeof(string),
            ownerType: typeof(ToggleButtonControl),
            typeMetadata: new FrameworkPropertyMetadata(defaultValue: string.Empty));
        public string OnText
        {
            get => (string)GetValue(OnTextProperty);
            set => SetValue(OnTextProperty, value);
        }

        public static readonly DependencyProperty OffTextProperty =
        DependencyProperty.Register(
            name: "OffText",
            propertyType: typeof(string),
            ownerType: typeof(ToggleButtonControl),
            typeMetadata: new FrameworkPropertyMetadata(defaultValue: string.Empty));
        public string OffText
        {
            get => (string)GetValue(OffTextProperty);
            set => SetValue(OffTextProperty, value);
        }
    }
}
