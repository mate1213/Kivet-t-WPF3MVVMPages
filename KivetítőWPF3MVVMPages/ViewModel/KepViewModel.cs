using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KivetítőWPF3MVVMPages.ViewModel
{
    public class KepViewModel : ViewModelBase
    {

        #region Field

        private double _width = proba.Default.Width;
        

        #endregion

        #region Property

        #region AutoPropertys
        public ViewModelLocator locator { get; set; }

        public RelayCommand Button_ClickCommand { get; set; }
        public RelayCommand ButtonFile_ClickCommand { get; set; }

        #endregion

        public double Width
        {
            get => _width; set
            {
                if (value > 49)
                {
                    foreach (var item in locator.MainView.kepAdatok)
                    {
                        item.Height = (int)(Width / item.Ratio);
                    }
                }
                _width = value;
                RaisePropertyChanged(() => this.Width);
            }
        }

        #endregion

        #region Constructor

        public KepViewModel()
        {
            locator = new ViewModelLocator();

            Button_ClickCommand = new RelayCommand(Click);
            ButtonFile_ClickCommand = new RelayCommand(ClickFile);
        }

        #endregion

        #region Methods

        private void Click()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                Model.Kep temp;
                string[] fajlok = Directory.GetFiles(fbd.SelectedPath);

                foreach (var item in fajlok)
                {
                    temp = new Model.Kep();
                    temp.KepHelye = item;
                    Bitmap bitmap = new Bitmap(item);
                    Size tempSize = bitmap.Size;
                    temp.Ratio = tempSize.Width / (double)tempSize.Height;
                    temp.Height = (int)(Width / temp.Ratio);
                    locator.MainView.kepAdatok.Add(temp);
                }
            }
            proba.Default.Save();
        }

        private void ClickFile()
        {
            OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Model.Kep temp;
                string[] fajlok = ofd.FileNames;

                foreach (var item in fajlok)
                {
                    Bitmap bitmap = new Bitmap(item);
                    Size tempSize = bitmap.Size;
                    temp = new Model.Kep();

                    temp.KepHelye = item;
                    temp.Ratio = tempSize.Width / (double)tempSize.Height;
                    temp.Height = (int)(Width / temp.Ratio);
                    locator.MainView.kepAdatok.Add(temp);
                }
            }
        }

        #endregion

    }
}
