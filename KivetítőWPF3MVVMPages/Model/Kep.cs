using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace KivetítőWPF3MVVMPages.Model
{
    public class Kep : ObservableObject
    {
        private string _kepHelye;
        private int _height;
        private int _width;

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

        public int Width
        {
            get => _width; set
            {
                _width = value;
                RaisePropertyChanged(() => this.Width);
            }
        }
    }
}
