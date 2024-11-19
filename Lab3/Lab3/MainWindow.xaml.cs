using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.text_box.FontFamily = new FontFamily(((TextBlock)((ComboBox)sender).SelectedItem).Text);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            this.text_box.FontSize = int.Parse(((TextBlock)((ComboBox)sender).SelectedItem).Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(this.text_box.FontWeight == FontWeights.Bold)
            {
                this.text_box.FontWeight = FontWeights.Normal;
                ((Button)sender).Background = null;
            }
            else
            {
                this.text_box.FontWeight = FontWeights.Bold;
                ((Button)sender).Background = Brushes.LightBlue;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.text_box.FontStyle == FontStyles.Italic)
            {
                this.text_box.FontStyle = FontStyles.Normal;
                ((Button)sender).Background = null;
            }
            else
            {
                this.text_box.FontStyle = FontStyles.Italic;
                ((Button)sender).Background = Brushes.LightBlue;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (this.text_box.TextDecorations.Contains(TextDecorations.Underline[0]))
            {
                this.text_box.TextDecorations.Remove(TextDecorations.Underline[0]);
                ((Button)sender).Background = null;
            }
            else
            {
                this.text_box.TextDecorations.Add(TextDecorations.Underline);
                ((Button)sender).Background = Brushes.LightBlue;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.text_box.Foreground = Brushes.Black;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            this.text_box.Foreground = Brushes.Red;
        }
    }
}
