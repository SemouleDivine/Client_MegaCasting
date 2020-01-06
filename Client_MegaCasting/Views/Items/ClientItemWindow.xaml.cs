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
using System.Windows.Shapes;
using Client_MegaCasting.ViewModel.Items;

namespace Client_MegaCasting.Views.Items
{
    /// <summary>
    /// Logique d'interaction pour ClientItemWindow.xaml
    /// </summary>
    public partial class ClientItemWindow : Window
    {
        private ClientItemViewModel newItem;

        public ClientItemWindow()
        {
            InitializeComponent();
        }

        public ClientItemWindow(ClientItemViewModel newItem)
        {
            this.newItem = newItem;
        }
    }
}
