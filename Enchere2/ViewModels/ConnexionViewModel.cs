using Enchere2.Models;
using Enchere2.Services;
using Enchere2.Views;
using Enchere2.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace Enchere2.ViewModels
{
    class ConnexionViewModel : BaseViewModel
    {
        private readonly Api _api = new Api();
        private bool authentification = false;
        public ConnexionViewModel()
        {
        }

        public async void Connect(string email, string password)
        {
            User u = new User(email, password, "nd", "nd", 0);
            u = await _api.GetOneAsync<User>("api/getUserByMailAndPass", u);

            if (u != null)
            {
                authentification = true;
                Storage.StockerId(u.Id.ToString());
                await Application.Current.MainPage.DisplayAlert("Bravo !", "Vous êtes connecté", "ok");
            }
            else
            {
                authentification = false;
                await Application.Current.MainPage.DisplayAlert("Login No", "Echec", "ok");
            }
        }
    }
}
