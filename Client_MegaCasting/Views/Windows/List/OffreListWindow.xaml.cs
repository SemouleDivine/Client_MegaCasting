using Client_MegaCasting.Views.Windows.Window;
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
    /// Logique d'interaction pour OffreListWindow.xaml
    /// </summary>
    public partial class OffreListWindow : Window
    {

        private MegaProdEntities myDb = new MegaProdEntities();

        public OffreListWindow()
        {
            InitializeComponent();
        }

        public void LoadOrReloadDatas()
        {
            var listOffre = myDb.Offre.ToList();
            DataGridContenu.ItemsSource = listOffre;
            DataGridContenu.Items.Refresh();
        }

        private void ButtonAjouter_Click(object sender, RoutedEventArgs e)
        {
            OffreWindow window = new OffreWindow();
            window.ShowDialog();

            //La fenêtre a été fermée
            if (window.DialogResult.HasValue && window.DialogResult == true)
            {
                try
                {
                    Offre OffreAAjouter = ((Offre)window.DataContext);
                    myDb.Offre.Add(OffreAAjouter);
                    myDb.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la sauvegarde + " + ex.Message);
                }
                LoadOrReloadDatas();
            }
        }

        private void ButtonModifier_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridContenu.SelectedItems.Count == 1)
            {
                Offre OffreAModifier = (Offre)DataGridContenu.SelectedItem;
                OffreWindow window = new OffreWindow(OffreAModifier);
                window.ShowDialog();

                if (window.DialogResult.HasValue && window.DialogResult == true)
                {
                    try
                    {
                        myDb.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la sauvegarde + " + ex.Message);
                    }
                }
                else
                {
                    myDb = new MegaProdEntities();
                }
                LoadOrReloadDatas();
            }
            else
            {
                MessageBox.Show("Merci de sélectionner 1 et un seul élément");
            }
        }

        private void ButtonSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridContenu.SelectedItems.Count == 1)
            {
                Offre OffreASupprimer = (Offre)DataGridContenu.SelectedItem;

                if (false)
                {
                    MessageBox.Show("Suppression impossible car la Offre possède des élèves à l'intérieur");
                    return;
                }

                if (MessageBox.Show("Souhaitez-vous rééllement supprimer cette offre ?",
                    "Suppression",
                    MessageBoxButton.YesNo)
                    == MessageBoxResult.Yes)
                {
                    try
                    {
                        myDb.Offre.Remove(OffreASupprimer);
                        myDb.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la sauvegarde + " + ex.Message);
                    }
                    LoadOrReloadDatas();
                }
            }
            else
            {
                MessageBox.Show("Merci de sélectionner 1 et un seul élément");
            }
        }
    }
}
