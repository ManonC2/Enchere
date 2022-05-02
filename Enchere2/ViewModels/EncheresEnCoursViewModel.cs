using Enchere2.Models;
using Enchere2.Services;
using Enchere2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Enchere2.ViewModels
{
    class EncheresEnCoursViewModel : BaseViewModel
    {
        #region Attributs
        private readonly Api _apiServices = new Api();
        private ObservableCollection<Enchere> _encheresClassiques;
        private ObservableCollection<Enchere> _encheresInverses;
        private ObservableCollection<Enchere> _encheresFlash;
        private ObservableCollection<Enchere> _enchereEnCours;
        private ObservableCollection<Enchere> _encheresAffichees;
        private Enchere _enchere;
        ObservableCollection<string> _listeNomEncheres;
        #endregion

        #region Constructeurs

        public EncheresEnCoursViewModel()
        {
            ListeNomEncheres = new ObservableCollection<string>();
            ListeNomEncheres.Add("Enchères Classiques");
            ListeNomEncheres.Add("Enchères Inversées");
            ListeNomEncheres.Add("Enchères Flash");
            GetEnchereEnCours();
            EnchereSimple = new Command(OnTapSelectedEnchere);
        }


        #endregion

        #region Getters/Setters
        public ObservableCollection<Enchere> EnchereEnCours
        {
            get { return _enchereEnCours; }
            set { SetProperty(ref _enchereEnCours, value); }
        }

        public ObservableCollection<Enchere> EncheresClassiques
        {
            get { return _encheresClassiques; }
            set { SetProperty(ref _encheresClassiques, value); }
        }

        public ObservableCollection<Enchere> EncheresInverses
        {
            get { return _encheresInverses; }
            set { SetProperty(ref _encheresInverses, value); }
        }

        public ObservableCollection<Enchere> EncheresFlash
        {
            get { return _encheresFlash; }
            set { SetProperty(ref _encheresFlash, value); }
        }

        public ObservableCollection<string> ListeNomEncheres
        {
            get { return _listeNomEncheres; }
            set { SetProperty(ref _listeNomEncheres, value); }
        }

        public ObservableCollection<Enchere> EncheresAffichees
        {
            get { return _encheresAffichees; }
            set { SetProperty(ref _encheresAffichees, value); }
        }


        public Enchere EnchereActuelle
        {
            get => _enchere;
            set => _enchere = value;
        }
        public Command EnchereSimple { get; }
        #endregion

        #region Methodes
        public async void GetEnchereEnCours()
        {
            EncheresAffichees = await _apiServices.GetAllAsync<Enchere>
                   ("api/getEncheresEnCours", Enchere.CollClasse);
        }

        public async Task<ObservableCollection<Enchere>> GetEncheresClassiques(int id)
        {
            EncheresClassiques = await _apiServices.GetAllAsyncID<Enchere>
                ("api/getEncheresEnCours", Enchere.CollClasse, "IdTypeEnchere", id);
            Enchere.CollClasse.Clear();
            return EncheresClassiques;
        }
        public async Task<ObservableCollection<Enchere>> GetEncheresInverses(int id)
        {
            EncheresInverses = await _apiServices.GetAllAsyncID<Enchere>
                ("api/getEncheresEnCours", Enchere.CollClasse, "IdTypeEnchere", id);
            Enchere.CollClasse.Clear();
            return EncheresInverses;

        }
        public async Task<ObservableCollection<Enchere>> GetEncheresFlash(int id)
        {
            EncheresFlash = await _apiServices.GetAllAsyncID<Enchere>
                ("api/getEncheresEnCours", Enchere.CollClasse, "IdTypeEnchere", id);
            Enchere.CollClasse.Clear();
            return EncheresFlash;

        }

        private async void OnTapSelectedEnchere()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EncherePage(EnchereActuelle));
        }

        public async  void AffichageEncheres(string selection)
        {
            Enchere.CollClasse.Clear();
            switch (selection)
            {
                case "Enchères Classiques":
                    //foreach(Enchere e in EncheresClassiques)
                    //{
                    //    EncheresAffichees.Add(e);
                    //}
                    EncheresAffichees = await GetEncheresClassiques(1);
                    break;
                case "Enchères Inversées":
                    EncheresAffichees = await GetEncheresInverses(2);
                    break;
                case "Enchères Flash":
                    EncheresAffichees = await GetEncheresFlash(3);
                    break;
            }

        }
    }
        }
        #endregion
