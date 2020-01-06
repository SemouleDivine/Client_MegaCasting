using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Client_MegaCasting.ViewModel.Items;
using Client_MegaCasting.ViewModel.Listings.Base;
using Client_MegaCasting.Views.Items;
using Client_MegaCastingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client_MegaCasting.ViewModel.Listings
{
    public class ClientListViewModel : BaseListViewModel<ClientItemViewModel>
    {

        #region Properties

        #endregion

        #region Constructeur(s)

        public ClientListViewModel() : base()
        {

        }

        #endregion

        #region Funcs

        public override void ReloadDatas()
        {
            Items = MyDb?.Client
                .ToList()
                .Select(x => new ClientItemViewModel(x))
                .ToList();
        }

        public override void Add()
        {
            //Ouverture de la fenêtre d'ajout
            ClientItemViewModel newItem = new ClientItemViewModel(null);
            ClientItemWindow window = new ClientItemWindow(newItem);
            window.ShowDialog();

            if (window.DialogResult.HasValue && window.DialogResult == true)
            {
                //On a appuyé sur OK
                //Sauvegarde
                try
                {
                    Client toAdd = newItem.ToEntity();
                    MyDb.Client.Add(toAdd);
                    MyDb.SaveChanges();
                    ReloadDatas();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la sauvegarde des données : " + ex.Message);
                }
            }
            //On a appuyé sur annuler ou on a crash dans la sauvegrde de l'item
            MyDb = new MegaProdEntities();
        }

        public override void Update()
        {
            if (Selected != null)
            {
                //Ouverture de la fenêtre d'ajout
                ClientItemViewModel itemToUpdate = Selected;
                ClientItemWindow window = new ClientItemWindow(itemToUpdate);
                window.ShowDialog();

                if (window.DialogResult.HasValue && window.DialogResult == true)
                {
                    //On a appuyé sur OK
                    //Sauvegarde
                    try
                    {
                        Client toAdd = itemToUpdate.ToEntity();
                        MyDb.SaveChanges();
                        ReloadDatas();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la sauvegarde des données : " + ex.Message);
                    }
                }
                //On a appuyé sur annuler ou on a crash dans la sauvegrde de l'item
                MyDb = new MegaProdEntities();
            }
        }

        public override void Delete()
        {
            if (Selected != null)
            {
                if (MessageBox.Show("Souhaitez-vous rééllement supprimer cet élément ?", 
                    "Suppresion",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        Client itemToDelete = Selected.ToEntity();
                        if (false/*itemToDelete.Commande.Any()*/)
                        {
                            MessageBox.Show("Suppression impossible car il existe des commandes associées");
                            return;
                        }
                        MyDb.Client.Remove(itemToDelete);
                        MyDb.SaveChanges();
                        ReloadDatas();
                        return;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la sauvegarde des données : " + ex.Message);
                    }
                    //Erreur à la suppression
                    MyDb = new MegaProdEntities();
                }
            }
        }

        #endregion

    }
}
