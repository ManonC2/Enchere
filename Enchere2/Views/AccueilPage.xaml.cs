using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Enchere2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccueilPage : ContentPage
    {
        public AccueilPage()
        {
            InitializeComponent();
        }

     void CreationCompteButton(object sender, System.EventArgs e)
    {
     Navigation.PushAsync(new CreationComptePage());        
     }
        void ConnexionButton(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConnexionPage());
        }
        void EncheresButton(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EncheresEnCoursPage());
        }
    }
}