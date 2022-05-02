using Enchere2.Models;
using Enchere2.Services;
using Enchere2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;


namespace Enchere2.ViewModels
{
    class CreationCompteViewModel : BaseViewModel
    {
        #region Attributs
        private readonly Api _apiService = new Api();
        #endregion

        #region Constructeur

        #endregion

        #region Getter/Setters

        #endregion

        #region Méthodes
        public async void PostRegisteredUser(User u)
        {
            var response = await _apiService.PostAsync<User>(u, "api/postUser");
            await Application.Current.MainPage.Navigation.PushAsync(new AccueilPage());
        }

        #endregion
    }
}
