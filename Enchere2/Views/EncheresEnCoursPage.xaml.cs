using Enchere2.Models;
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

        void SelectedEnchere(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var enchere = (Enchere)e.CurrentSelection.FirstOrDefault();
            Navigation.PushAsync(new EncherePage(enchere));
        }

        async void PickerSelection(System.Object sender, Syncfusion.SfPicker.XForms.SelectionChangedEventArgs e)
        {
            string pickerSelection = picker.SelectedItem.ToString();
            collection.IsVisible = true;
            boutonPicker.IsVisible = true;
            viewModel.AffichageEncheres(pickerSelection);
        }

        void PickerApparition(System.Object sender, System.EventArgs e)
        {
            collection.IsVisible = true;
            picker.IsOpen = true;
            boutonPicker.IsVisible = false;
        }
    }
}
