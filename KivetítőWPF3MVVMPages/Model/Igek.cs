using GalaSoft.MvvmLight;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System;

namespace KivetítőWPF3MVVMPages.Model
{ 
    public class Igek : ObservableObject
    {

        #region Fields

        private Tuple<string, string> _igereszKaroli;
        private Tuple<string, int> _fejezetKaroli;

        #endregion

        #region Igek Propery-jei

        public Tuple<string, string> IgereszKaroli
        {
            get => _igereszKaroli; set
            {
                _igereszKaroli = value;
                RaisePropertyChanged(() => this.IgereszKaroli);
            }
        }

        public Tuple<string, int> FejezetKaroli
        {
            get => _fejezetKaroli; set
            {
                _fejezetKaroli = value;
                RaisePropertyChanged(() => this.FejezetKaroli);
            }
        }

        #endregion

    }
}
