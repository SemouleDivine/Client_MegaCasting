using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_MegaCasting.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        #region Properties

        private object listingEnCours;
        public object ListingEnCours
        {
            get { return listingEnCours; }
            set
            {
                listingEnCours = value;
                RaisePropertyChanged("ListingEnCours");
            }
        }

        private RelayCommand quitterCommand;
        public RelayCommand QuitterCommand
        {
            get { return quitterCommand; }
            set
            {
                quitterCommand = value;
                RaisePropertyChanged("QuitterCommand");
            }
        }

        #endregion

        #region Constructeur(s)

        public MainViewModel()
        {
            this.QuitterCommand = new RelayCommand(Quitter);
        }

        #endregion

        #region Funcs

        private void Quitter()
        {
            App.Current.Shutdown();
        }

        #endregion

    }
}
