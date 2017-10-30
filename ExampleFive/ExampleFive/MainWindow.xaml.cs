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

namespace ExampleFive
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

        private void FavoritesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            userWebBrowser.Source = new Uri(favoritesComboBox.SelectedItem.ToString());
        }

        private void FavoriteButton_Click(object sender, RoutedEventArgs e)
        {
                favoritesComboBox.Items.Add(userWebBrowser.Source);
        }

        private void GOButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                userWebBrowser.Source = new Uri(linkTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильная ссылка!");
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            linkTextBox.Text = "http://www.google.com";
        }
    }
}
