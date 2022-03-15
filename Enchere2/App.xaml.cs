using Enchere2.Services;
using Enchere2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Enchere2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            
            MainPage = new AppShell();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
