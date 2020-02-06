using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_MegaCasting_App.ViewModels.Items
{
    class MainItemViewModel : ViewModelBase
    {

		#region - Properties -

		#region - Vue -

		private RelayCommand entrepriseCommand;
		public RelayCommand EntrepriseCommand
		{
			get { return entrepriseCommand; }
			set
			{
				entrepriseCommand = value;
				RaisePropertyChanged("EntrepriseCommand");
			}
		}

		private RelayCommand offreCommand;
		public RelayCommand OffreCommand
		{
			get { return offreCommand; }
			set
			{
				offreCommand = value;
				RaisePropertyChanged("OffreCommand");
			}
		}

		private RelayCommand articleCommand;
		public RelayCommand ArticleCommand
		{
			get { return articleCommand; }
			set
			{
				articleCommand = value;
				RaisePropertyChanged("ArticleCommand");
			}
		}

		#endregion

		#region - Verification - 
		/*
		private bool loading_IsDisplayed;

		public bool Loading_IsDisplayed
		{
			get { return loading_IsDisplayed; }
			set
			{
				loading_IsDisplayed = value;
				RaisePropertyChanged("Loading_IsDisplayed");
			}
		}

		#region - Is_Ok -
		public bool IsOk
		{
			get
			{
				return Serveur_IsOk &&
					Instance_IsOk &&
					Port_IsOk &&
					User_IsOk &&
					Mdp_IsOk &&
					Chemin_IsOk;
			}
		}

		private bool serveur_IsOk;
		public bool Serveur_IsOk
		{
			get { return serveur_IsOk; }
			set
			{
				serveur_IsOk = value;
				RaisePropertyChanged("Serveur_IsOk");
				RaisePropertyChanged(nameof(IsOk));
			}
		}

		private bool instance_IsOk;
		public bool Instance_IsOk
		{
			get { return instance_IsOk; }
			set
			{
				instance_IsOk = value;
				RaisePropertyChanged("Instance_IsOk");
				RaisePropertyChanged(nameof(IsOk));
			}
		}

		private bool port_IsOk;
		public bool Port_IsOk
		{
			get { return port_IsOk; }
			set
			{
				port_IsOk = value;
				RaisePropertyChanged("Port_IsOk");
				RaisePropertyChanged(nameof(IsOk));
			}
		}

		private bool user_IsOk;
		public bool User_IsOk
		{
			get { return user_IsOk; }
			set
			{
				user_IsOk = value;
				RaisePropertyChanged("User_IsOk");
				RaisePropertyChanged(nameof(IsOk));
			}
		}

		private bool mdp_IsOk;
		public bool Mdp_IsOk
		{
			get { return mdp_IsOk; }
			set
			{
				mdp_IsOk = value;
				RaisePropertyChanged("Mdp_IsOk");
				RaisePropertyChanged(nameof(IsOk));
			}
		}

		private bool chemin_IsOk;
		public bool Chemin_IsOk
		{
			get { return chemin_IsOk; }
			set
			{
				chemin_IsOk = value;
				RaisePropertyChanged("Chemin_IsOk");
				RaisePropertyChanged(nameof(IsOk));
			}
		}
		*/
		#endregion

		#region - Errors -
		/*
		private string serveur_Error;
		public string Serveur_Error
		{
			get { return serveur_Error; }
			set
			{
				serveur_Error = value;
				RaisePropertyChanged(nameof(Serveur_Error));
			}
		}

		private string instance_Error;
		public string Instance_Error
		{
			get { return instance_Error; }
			set
			{
				instance_Error = value;
				RaisePropertyChanged(nameof(Instance_Error));
			}
		}

		private string port_Error;
		public string Port_Error
		{
			get { return port_Error; }
			set
			{
				port_Error = value;
				RaisePropertyChanged(nameof(Port_Error));
			}
		}

		private string user_Error;
		public string User_Error
		{
			get { return user_Error; }
			set
			{
				user_Error = value;
				RaisePropertyChanged(nameof(User_Error));
			}
		}

		private string mdp_Error;
		public string Mdp_Error
		{
			get { return mdp_Error; }
			set
			{
				mdp_Error = value;
				RaisePropertyChanged(nameof(Mdp_Error));
			}
		}

		private string chemin_Error;
		public string Chemin_Error
		{
			get { return chemin_Error; }
			set
			{
				chemin_Error = value;
				RaisePropertyChanged(nameof(Chemin_Error));
			}
		}
		*/

		#endregion

		#endregion

		/*
		private string environnement;

		public string Environnement
		{
			get { return environnement; }
			set
			{
				if (environnement != value)
				{
					environnement = value;
					RaisePropertyChanged("Environnement");

				}
			}
		}

		private string serveur;

		public string Serveur
		{
			get { return serveur; }
			set
			{

				if (serveur != value)
				{
					serveur = value;
					RaisePropertyChanged("Serveur");
				}
				if (string.IsNullOrWhiteSpace(Serveur))
				{
					Serveur_IsOk = false;
					Serveur_Error = "Merci de renseigner ce champ";
				}
				else
				{
					Serveur_IsOk = true;
					Serveur_Error = string.Empty;
				}
			}
		}

		private string instance;

		public string Instance
		{
			get { return instance; }
			set
			{
				if (instance != value)
				{
					instance = value;
					RaisePropertyChanged("Instance");
				}
				if (string.IsNullOrWhiteSpace(Instance))
				{
					Instance_IsOk = false;
					Instance_Error = "Merci de renseigner ce champ";
				}
				else
				{
					Instance_IsOk = true;
					Instance_Error = string.Empty;
				}
			}
		}

		private string port;

		public string Port
		{
			get { return port; }
			set
			{
				if (port != value)
				{
					port = value;
					RaisePropertyChanged("Port");
				}
				if (string.IsNullOrWhiteSpace(Port))
				{
					Port_IsOk = false;
					Port_Error = "Merci de renseigner ce champ";
				}
				else
				{
					Port_IsOk = true;
					Port_Error = string.Empty;
				}
			}
		}

		private string user;

		public string User
		{
			get { return user; }
			set
			{
				if (user != value)
				{
					user = value;
					RaisePropertyChanged("User");
				}
				if (string.IsNullOrWhiteSpace(User))
				{
					User_IsOk = false;
					User_Error = "Merci de renseigner ce champ";
				}
				else
				{
					User_IsOk = true;
					User_Error = string.Empty;
				}
			}
		}

		private string mdp;

		public string Mdp
		{
			get { return mdp; }
			set
			{
				if (mdp != value)
				{
					mdp = value;
					RaisePropertyChanged("Mdp");
				}
				if (string.IsNullOrWhiteSpace(Mdp))
				{
					Mdp_IsOk = false;
					Mdp_Error = "Merci de renseigner ce champ";
				}
				else
				{
					Mdp_IsOk = true;
					Mdp_Error = string.Empty;
				}
			}
		}

		private string chemin;

		public string Chemin
		{
			get { return chemin; }
			set
			{
				if (chemin != value)
				{
					chemin = value;
					RaisePropertyChanged("Chemin");
				}
				if (string.IsNullOrWhiteSpace(Chemin))
				{
					Chemin_IsOk = false;
					Chemin_Error = "Merci de renseigner ce champ";
				}
				else
				{
					Chemin_IsOk = true;
					Chemin_Error = string.Empty;
				}
			}
		}

		private int loading_Value;

		public int Loading_Value
		{
			get { return loading_Value; }
			set
			{
				loading_Value = value;
				RaisePropertyChanged("Loading_Value");
			}
		}
		
#endregion */

		#region - Constructor(s) -

		public MainItemViewModel()
		{

			EntrepriseCommand = new RelayCommand(Entreprise);
			OffreCommand = new RelayCommand(Offre);
			ArticleCommand = new RelayCommand(Article);

		}

        #endregion

        #region - Function(s) - 

		private void Entreprise()
		{

		}

		private void Offre()
		{

		}

		private void Article()
		{

		}

        #endregion

    }
}
