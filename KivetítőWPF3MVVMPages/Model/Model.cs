using GalaSoft.MvvmLight;
using System.Windows.Controls;

namespace KivetítőWPF3MVVMPages.Model
{
    public class Model : ObservableObject
    {
        #region Fields

        private Page _lapok;
        private Page _lapokEszkozok;

        #endregion

        #region Propertys
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
        #endregion
    }
}
