using GalaSoft.MvvmLight;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System;

namespace KivetítőWPF3MVVMPages.Model
{
    public class Model : ObservableObject
    {
        #region Fields

        private Page _lapok;
        private Page _lapokEszkozok;
        private int _mainWidth;
        private ObservableCollection<string> _cim;
        private ObservableCollection<string> _szoveg;
        private ObservableCollection<string> _szerzo;
        private int _darabolas;

        #endregion

        #region Propertys

        #region main Window Property-jei

        public Page Lapok
        {
            get => _lapok;
            set
            {
                _lapok = value;
                RaisePropertyChanged(() => this.Lapok);
            }
        }

        public Page LapokEszkozok
        {
            get => _lapokEszkozok;
            set
            {
                _lapokEszkozok = value;
                RaisePropertyChanged(() => this.LapokEszkozok);
            }
        }

        public int MainWidth
        {
            get => _mainWidth; set
            {
                _mainWidth = value;
                RaisePropertyChanged(() => this.MainWidth);
            }
        }

        #endregion

        #endregion
    }
}
