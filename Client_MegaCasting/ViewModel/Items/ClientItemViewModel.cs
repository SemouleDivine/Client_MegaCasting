using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Client_MegaCasting.Views.Items;
using Client_MegaCastingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_MegaCasting.ViewModel.Items
{
    public class ClientItemViewModel : ViewModelBase
    {

        #region Properties

        #region Entities

        public Client associated_entity;

        private long identifiant;
        public long Identifiant
        {
            get { return identifiant; }
            set
            {
                if (identifiant != value)
                {
                    identifiant = value;
                    RaisePropertyChanged("Identifiant");
                }
            }
        }

        private string libelle;
        public string Libelle
        {
            get { return libelle; }
            set
            {
                if (libelle != value)
                {
                    libelle = value;
                    RaisePropertyChanged("Libelle");
                }
                //TESTS
                //Test chaine vide
                if (string.IsNullOrWhiteSpace(Libelle))
                {
                    Libelle_IsOk = false;
                    Libelle_Error = "Merci de renseigner ce champ";
                }
                else if (Libelle.Length > 255)
                {
                    Libelle_IsOk = false;
                    Libelle_Error = "Ce champ doit faire maximum 255 caractères (actuellement "
                        + libelle.Length
                        + ")";
                }
                else
                {
                    Libelle_IsOk = true;
                    Libelle_Error = string.Empty;
                }
            }
        }

        private string adresse;
        public string Adresse
        {
            get { return adresse; }
            set
            {
                if (adresse != value)
                {
                    adresse = value;
                    RaisePropertyChanged("Adresse");
                }
                //TESTS
                //Test chaine vide
                if (string.IsNullOrWhiteSpace(Adresse))
                {
                    Adresse_IsOk = false;
                    Adresse_Error = "Merci de renseigner ce champ";
                }
                else if (Adresse.Length > 255)
                {
                    Adresse_IsOk = false;
                    Adresse_Error = "Ce champ doit faire maximum 255 caractères (actuellement "
                        + libelle.Length
                        + ")";
                }
                else
                {
                    Adresse_IsOk = true;
                    Adresse_Error = string.Empty;
                }
            }
        }

        private string code_postal;
        public string Code_Postal
        {
            get { return code_postal; }
            set
            {
                if (code_postal != value)
                {
                    code_postal = value;
                    RaisePropertyChanged("Code_Postal");
                }
                //TESTS
                //Test chaine vide
                if (string.IsNullOrWhiteSpace(Code_Postal))
                {
                    Code_Postal_IsOk = false;
                    Code_Postal_Error = "Merci de renseigner ce champ";
                }
                else if (Code_Postal.Length != 5)
                {
                    Code_Postal_IsOk = false;
                    Code_Postal_Error = "Ce champ doit faire 5 caractères (actuellement "
                        + libelle.Length
                        + ")";
                }
                else if (!int.TryParse(Code_Postal, out int converted))
                {
                    Code_Postal_IsOk = false;
                    Code_Postal_Error = "Ce champ être au format numérique";
                }
                else
                {
                    Code_Postal_IsOk = true;
                    Code_Postal_Error = string.Empty;
                }
            }
        }

        private string ville;
        public string Ville
        {
            get { return ville; }
            set
            {
                if (ville != value)
                {
                    ville = value;
                    RaisePropertyChanged("Ville");
                }
                //TESTS
                //Test chaine vide
                if (string.IsNullOrWhiteSpace(Ville))
                {
                    Ville_IsOk = false;
                    Ville_Error = "Merci de renseigner ce champ";
                }
                else if (Ville.Length > 255)
                {
                    Ville_IsOk = false;
                    Ville_Error = "Ce champ doit faire maximum 255 caractères (actuellement "
                        + libelle.Length
                        + ")";
                }
                else
                {
                    Ville_IsOk = true;
                    Ville_Error = string.Empty;
                }
            }
        }

        #endregion

        #region Vue

        #region Verifications

        public bool IsOk
        {
            get
            {
                return Libelle_IsOk && Adresse_IsOk && Code_Postal_IsOk && Ville_IsOk;
            }
        }

        private bool libelle_IsOk;
        public bool Libelle_IsOk
        {
            get { return libelle_IsOk; }
            set
            {
                libelle_IsOk = value;
                RaisePropertyChanged("Libelle_IsOk");
                RaisePropertyChanged(nameof(IsOk));
            }
        }

        private string libelle_Error;
        public string Libelle_Error
        {
            get { return libelle_Error; }
            set
            {
                libelle_Error = value;
                RaisePropertyChanged(nameof(Libelle_Error));
            }
        }

        private bool adresse_IsOk;
        public bool Adresse_IsOk
        {
            get { return adresse_IsOk; }
            set
            {
                adresse_IsOk = value;
                RaisePropertyChanged(nameof(Adresse_IsOk));
                RaisePropertyChanged(nameof(IsOk));
            }
        }

        private string adresse_Error;
        public string Adresse_Error
        {
            get { return adresse_Error; }
            set
            {
                adresse_Error = value;
                RaisePropertyChanged(nameof(Adresse_Error));
            }
        }


        private bool code_Postal_IsOk;
        public bool Code_Postal_IsOk
        {
            get { return code_Postal_IsOk; }
            set
            {
                code_Postal_IsOk = value;
                RaisePropertyChanged(nameof(Code_Postal_IsOk));
                RaisePropertyChanged(nameof(IsOk));
            }
        }

        private string code_Postal_Error;
        public string Code_Postal_Error
        {
            get { return code_Postal_Error; }
            set
            {
                code_Postal_Error = value;
                RaisePropertyChanged(nameof(Code_Postal_Error));
            }
        }


        private bool ville_IsOk;
        public bool Ville_IsOk
        {
            get { return ville_IsOk; }
            set
            {
                ville_IsOk = value;
                RaisePropertyChanged(nameof(Ville_IsOk));
                RaisePropertyChanged(nameof(IsOk));
            }
        }

        private string ville_Error;
        public string Ville_Error
        {
            get { return ville_Error; }
            set
            {
                ville_Error = value;
                RaisePropertyChanged(nameof(Ville_Error));
            }
        }


        #endregion

        public ClientItemWindow windowAssociee;

        private RelayCommand validerCommand;
        public RelayCommand ValiderCommand
        {
            get { return validerCommand; }
            set
            {
                validerCommand = value;
                RaisePropertyChanged("ValiderCommand");
            }
        }

        private RelayCommand cancelCommand;
        public RelayCommand CancelCommand
        {
            get { return cancelCommand; }
            set
            {
                cancelCommand = value;
                RaisePropertyChanged("CancelCommand");
            }
        }

        #endregion

        #endregion

        #region Constructeur(s)

        public ClientItemViewModel(Client client)
        {
            if (client == null)
            {
                client = new Client();
            }
            this.associated_entity = client;
            /*
            this.Identifiant = client?.Identifiant ?? 0;
            this.Libelle = client?.Libelle;
            this.Adresse = client?.Adresse;
            this.Code_Postal = client?.Code_Postal;
            this.Ville = client?.Ville;*/

            ValiderCommand = new RelayCommand(Valider);
            CancelCommand = new RelayCommand(Annuler);
        }

        #endregion

        #region Funcs

        public Client ToEntity()
        {
            Client toReturn = associated_entity;

            /*
            toReturn.Libelle = this.Libelle;
            toReturn.Adresse = this.Adresse;
            toReturn.Code_Postal = this.Code_Postal;
            toReturn.Ville = this.Ville;*/

            return toReturn;
        }

        private void Valider()
        {
            if (windowAssociee != null && IsOk)
            {
                windowAssociee.DialogResult = true;
                windowAssociee.Close();
            }
        }

        private void Annuler()
        {
            if (windowAssociee != null)
            {
                windowAssociee.DialogResult = false;
                windowAssociee.Close();
            }
        }

        #endregion

    }
}
