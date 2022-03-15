using Enchere2.Modeles;
using Enchere2.Services;
using Enchere2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Enchere2.ViewModels
{
    class EncheresEnCoursViewModel : BaseViewModel
    {
        #region Attributs
        private readonly Api _apiServices = new Api();
        ObservableCollection<Enchere> _maListeEnchere;
        ObservableCollection<Enchere> _enchereEnCours;
        private List<int> _maListeTest;
        private Enchere _enchere;
        #endregion

        #region Constructeurs

        public EncheresEnCoursViewModel()
        {
            MaListeTest = new List<int>();
            GetEnchere();
            GetEnchereEnCours();
            EnchereSimple = new Command(OnTapSelectedEnchere);
        }


        #endregion

        #region Getters/Setters
        public ObservableCollection<Enchere> MaListeEnchere
        {
            get { return _maListeEnchere; }
            set { SetProperty(ref _maListeEnchere, value); }
        }
        public ObservableCollection<Enchere> EnchereEnCours
        {
            get { return _enchereEnCours; }
            set { SetProperty(ref _enchereEnCours, value); }
        }


        public List<int> MaListeTest
        {
            get { return _maListeTest;  }
            set { SetProperty(ref _maListeTest, value); }
        }

        public Enchere EnchereActuelle
        {
            get => _enchere;
            set => _enchere = value;
        }
        public Command EnchereSimple { get; }
        #endregion

        #region Methodes
        //public async void GetOneEnchere(Enchere uneEnchere)
        //{
        //    Enchere.CollClasse.Clear();
        //    Enchere res = await _apiServices.GetOneAsync<Enchere>
        //           ("api/getEnchereTestObjet", Enchere.CollClasse, uneEnchere.Id);
        //}

        public async void GetEnchere()
        {
            MaListeEnchere = await _apiServices.GetAllAsync<Enchere>
                   ("api/getEnchere", Enchere.CollClasse);
        }
        public async void GetEnchereEnCours()
        {
            EnchereEnCours = await _apiServices.GetAllAsync<Enchere>
                   ("api/getEncheresEnCours", Enchere.CollClasse);
        }

        private async void OnTapSelectedEnchere()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EncherePage(EnchereActuelle));
        }
        #endregion
    }
}
