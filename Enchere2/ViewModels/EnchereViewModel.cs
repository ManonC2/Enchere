using Enchere2.Models;
using Enchere2.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enchere2.ViewModels
{
    class EnchereViewModel : BaseViewModel
    {
        private readonly Api _apiServices = new Api();
        private Enchere _enchere;
        private double _progress;
        private Encherir _lEncherir;

        public EnchereViewModel(Enchere enchere)
        {
            _enchere = enchere;
            ProgressValue();
            GetEncherir();
        }

        public Enchere LaEnchere
        {
            get { return _enchere; }
            set { SetProperty(ref _enchere, value); }
        }

        public double Progress
        {
            get { return _progress; }
            set { SetProperty(ref _progress, value); }
        }

        public Encherir LEncherir
        {
            get { return _lEncherir; }
            set { SetProperty(ref _lEncherir, value); }
        }

        public async void GetEncherir()
        {
            LEncherir = await _apiServices.GetOneAsyncID<Encherir>("api/getActualPrice", LaEnchere.Id.ToString());
        }
        public void ProgressValue()
        {
            double totalNatif = (LaEnchere.Date_fin - LaEnchere.Date_debut).TotalSeconds;
            double totalNow = (DateTime.Now - LaEnchere.Date_debut).TotalSeconds;
            Progress = totalNow / totalNatif;
        }
        
    }
}
