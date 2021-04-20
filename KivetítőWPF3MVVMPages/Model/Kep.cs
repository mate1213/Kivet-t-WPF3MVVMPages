using GalaSoft.MvvmLight;

namespace KivetítőWPF3MVVMPages.Model
{
    public class Kep : ObservableObject
    {
        private string _kepHelye;
        private int _height;
        private double _ratio;

        public string KepHelye
        {
            get => _kepHelye; set
            {
                _kepHelye = value;
                RaisePropertyChanged(() => this.KepHelye);
            }
        }

        public int Height
        {
            get => _height; set
            {
                _height = value;
                RaisePropertyChanged(() => this.Height);
            }
        }

        public double Ratio
        {
            get => _ratio; set
            {
                _ratio = value;
                RaisePropertyChanged(() => this.Ratio);
            }
        }
    }
}
