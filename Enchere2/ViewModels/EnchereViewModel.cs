using Enchere2.Modeles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enchere2.ViewModels
{
    class EnchereViewModel : BaseViewModel
    {
        private Enchere _enchere;
        public EnchereViewModel(Enchere enchere)
        {
            _enchere = enchere;
        }

        public Enchere LaEnchere
        {
            get { return _enchere; }
            set { SetProperty(ref _enchere, value); }
        }
    }
}
