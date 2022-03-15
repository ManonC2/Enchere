using Enchere2.ViewModels;
using Enchere2.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Enchere2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        private async void OnEnchereClickItem(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("");
        }
    }
}
