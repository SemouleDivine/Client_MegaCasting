using Client_MegaCasting.ViewModel;
using Client_MegaCasting.Views.Listings;
using Client_MegaCasting.Views.Windows;
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

namespace Client_MegaCasting
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void ClientClick(object sender, RoutedEventArgs e)
        {
            (new ClientListWindow()).ShowDialog();
        }

        private void PartenaireClick(object sender, RoutedEventArgs e)
        {

        }

        private void OffreClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
