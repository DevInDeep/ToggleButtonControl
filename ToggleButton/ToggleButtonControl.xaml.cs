using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media;

namespace ToggleButton
{
    /// <summary>
    /// Interaction logic for ToggleButtonControl.xaml
    /// </summary>
    public partial class ToggleButtonControl : UserControl
    {
        public ToggleButtonControl() => InitializeComponent();
        private void ToggleButton_Click(object sender, MouseButtonEventArgs e)
        {
            IsChecked = !IsChecked;
            background.Background = IsChecked ? new SolidColorBrush(OnColor) : new SolidColorBrush(Colors.Gray);
        }
    }
}
