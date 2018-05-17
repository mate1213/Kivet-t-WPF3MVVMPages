using GalaSoft.MvvmLight;

namespace KivetítőWPF3MVVMPages.Model
{
    public class ButtonContent : ObservableObject
    {
        #region Field

        private string _igeButtonContent;
        private string _dalButtonContent;
        private string _kepButtonContent;
        private string _videoButtonContent;

        #endregion

        #region Property

        public string IgeButtonContent
        {
            get => _igeButtonContent;
            set
            {
                _igeButtonContent = value;
                RaisePropertyChanged(() => this._igeButtonContent);
            }
        }

        public string DalButtonContent
        {
            get => _dalButtonContent;
            set
            {
                _dalButtonContent = value;
                RaisePropertyChanged(() => this._dalButtonContent);
            }
        }

        public string KepButtonContent
        {
            get => _kepButtonContent;
            set
            {
                _kepButtonContent = value;
                RaisePropertyChanged(() => this._kepButtonContent);
            }
        }
        public string VideoButtonContent
        {
            get => _videoButtonContent; set
            {
                _videoButtonContent = value;
                RaisePropertyChanged(() => this._videoButtonContent);
            }
        }

        #endregion

    }
}
