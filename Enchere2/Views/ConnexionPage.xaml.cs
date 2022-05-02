using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enchere2.Models;
using Enchere2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text.RegularExpressions;

namespace Enchere2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnexionPage : ContentPage
    {
        ConnexionViewModel viewModel;

        Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public ConnexionPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ConnexionViewModel();
        }

        public bool ValidationEmailRegex(string mail)
        {
            if (string.IsNullOrWhiteSpace(mail))
            {
                return false;
            }
            else
            {
                return regexEmail.IsMatch(mail);
            }
        }

        async void ConnexionClicked(System.Object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(EmailEntre.Text) && !string.IsNullOrEmpty(PasswordEntre.Text))
            {
                if (ValidationEmailRegex(EmailEntre.Text))
                {
                   viewModel.Connect(EmailEntre.Text, PasswordEntre.Text);
                }
                else
                {
                    await DisplayAlert("Erreur", "L'adresse email saisie n'est pas valide", "ok");
                }
            }
            else
            {
                await DisplayAlert("Erreur", "Vous n'avez pas rempli tous les champs du formulaire", "ok");
            }

        }
    }
}