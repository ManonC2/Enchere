using Enchere2.Models;
using Enchere2.Services;
using Enchere2.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Enchere2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreationComptePage : ContentPage
    {
        #region Attributs
        CreationCompteViewModel viewModel;
        readonly Api _apiService = new Api();
        Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        #endregion

        #region Constructeur
        public CreationComptePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new CreationCompteViewModel();
        }
        #endregion

        #region Getters/Setters
        #endregion

        #region Méthodes
        public bool ValidationEmailRegex(string mail)
        {
            if(string.IsNullOrWhiteSpace(mail))
            {
                return false;
            } else
            {
                return regexEmail.IsMatch(mail);
            }
        }

        async void InscriptionClicked(System.Object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(EmailEntre.Text) && !string.IsNullOrEmpty(PasswordEntre.Text) && !string.IsNullOrEmpty(PseudoEntre.Text))
            {
                if (ValidationEmailRegex(EmailEntre.Text))
                {
                    User u = new User(EmailEntre.Text, PasswordEntre.Text, PseudoEntre.Text, "1", 0);
                    viewModel.PostRegisteredUser(u);
                } else
                {
                    await DisplayAlert("Erreur", "L'adresse email saisie n'est pas valide", "ok");
                }
            } else
            {
                await DisplayAlert("Erreur", "Vous n'avez pas rempli tous les champs du formulaire", "ok");
            }
        }
        #endregion

    }
}
