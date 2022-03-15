using Enchere2.Modeles;
using Enchere2.Services;
using Enchere2.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Enchere2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EncheresEnCoursPage : ContentPage
    {
        EncheresEnCoursViewModel viewModel;
        private readonly Api _apiServices = new Api();

        public EncheresEnCoursPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new EncheresEnCoursViewModel();
        }


    }
}
