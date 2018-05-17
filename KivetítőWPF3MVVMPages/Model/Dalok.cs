using GalaSoft.MvvmLight;
using System.Windows.Controls;

namespace KivetítőWPF3MVVMPages.Model
{
    public class Dalok : ObservableObject
    {
        #region Fields
        private string _cim;
        private string _szoveg;
        private string _szerzo;
        private int _darabolas;

        #endregion

        #region Propertys

        public string Cim
        {
            get => _cim; set
            {
                _cim = value;
                RaisePropertyChanged(() => this.Cim);
            }
        }

        public string Szoveg
        {
            get => _szoveg; set
            {
                _szoveg = value;
                RaisePropertyChanged(() => this.Szoveg);
            }
        }

        public string Szerzo
        {
            get => _szerzo; set
            {
                _szerzo = value;
                RaisePropertyChanged(() => this.Szerzo);
            }
        }

        public int Darabolas
        {
            get => _darabolas; set
            {
                _darabolas = value;
                RaisePropertyChanged(() => this.Darabolas);
            }
        }

        #endregion
    }
}
