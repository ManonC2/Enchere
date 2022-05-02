using Enchere2.Models;
using Enchere2.ViewModels;
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
    public partial class EncherePage : ContentPage
    {
        EnchereViewModel viewModel;

        public EncherePage(Enchere enchere)
        {
            InitializeComponent();
            BindingContext = viewModel = new EnchereViewModel(enchere);
        }

        protected override void OnAppearing()
        {
            double progress = viewModel.Progress;
            progressBar.ProgressTo(viewModel.Progress, 2250, Easing.CubicIn) ;
        }
    }
}