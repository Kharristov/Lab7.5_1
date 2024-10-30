using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7._5_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var focusedTextBox = sender as TextBox;

            if (focusedTextBox != null)
            {
                if (focusedTextBox.Style == Resources["SmallTextBoxStyle"] as Style)
                {
                    focusedTextBox.Style = Resources["LargeTextBoxStyle"] as Style;
                }

                Storyboard storyboard = Resources["FocusAnimation"] as Storyboard;
                if (storyboard != null)
                {
                    storyboard.Begin(focusedTextBox);
                }
            }
        }
    }
}