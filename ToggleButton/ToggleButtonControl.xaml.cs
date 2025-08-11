using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Controls;

namespace ToggleButton
{
    /// <summary>
    /// Interaction logic for ToggleButtonControl.xaml
    /// </summary>
    public partial class ToggleButtonControl : UserControl
    {
        public event EventHandler<bool> ToggleButtonStateChanged;
        public ToggleButtonControl() => InitializeComponent();
        private void ToggleButton_Click(object sender, MouseButtonEventArgs e)
        {
            IsChecked = !IsChecked;
            background.Background = IsChecked ? new SolidColorBrush(OnColor) : new SolidColorBrush(Colors.Gray);
            ToggleButtonStateChanged?.Invoke(this, IsChecked);
        }
    }
}
