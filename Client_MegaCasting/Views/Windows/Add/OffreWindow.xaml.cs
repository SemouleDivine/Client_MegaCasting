using Client_MegaCastingModel;
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

namespace Client_MegaCasting.Views.Windows
{
    /// <summary>
    /// Logique d'interaction pour OffreWindow.xaml
    /// </summary>
    public partial class OffreWindow : Window
    {
  
        #region Constructeurs

        public OffreWindow()    
        {
            InitializeComponent();
            this.DataContext = new Offre();
        }

        public OffreWindow(Offre OffreAModifier)
        {
            InitializeComponent();
            this.DataContext = OffreAModifier;
        }

        #endregion

        private bool VerificationChamps()
        {
            return true;
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            if (VerificationChamps())
            {
                this.DialogResult = true;
                this.Close();
            }
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
