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
        private ObservableCollection<Model.Kep> _model;
        private double _width = 150;
        #endregion

        #region Property

        public ObservableCollection<Model.Kep> model { get => _model; set => _model = value; }
        public RelayCommand<string> Button_ClickCommand { get; set; }
        public RelayCommand<string> ButtonFile_ClickCommand { get; set; }
        public double Width
        {
            get => _width; set
            {
                _width = value;
                RaisePropertyChanged(() => this.Width);
            }
        }

        #endregion
        
        #region Constructor
        public KepViewModel()
        {
            model = new ObservableCollection<Model.Kep>();
            Button_ClickCommand = new RelayCommand<string>(Click);
            ButtonFile_ClickCommand = new RelayCommand<string>(ClickFile);
        }
        #endregion

        private void Click(string width)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                Model.Kep temp;
                double ratio;
                string[] fajlok = Directory.GetFiles(fbd.SelectedPath);

                foreach (var item in fajlok)
                {
                    temp = new Model.Kep();
                    temp.KepHelye = item;
                    Bitmap bitmap = new Bitmap(item);
                    Size tempSize = bitmap.Size;
                    ratio = (double)tempSize.Width / (double)tempSize.Height;
                    temp.Width = 200;
                    temp.Height = (int)((double)temp.Width / ratio);
                    model.Add(temp);
                }
            }
        }

        private void ClickFile(string width)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Model.Kep temp;
                double ratio, tempDouble;
                string[] fajlok = ofd.FileNames;
                double.TryParse(width, out tempDouble);
                Width = tempDouble;

                foreach (var item in fajlok)
                {
                    temp = new Model.Kep();
                    temp.KepHelye = item;
                    Bitmap bitmap = new Bitmap(item);
                    Size tempSize = bitmap.Size;
                    ratio = tempSize.Width / (double)tempSize.Height;
                    temp.Height = (int)(Width / ratio);
                    model.Add(temp);
                }
            }
        }

        protected override void RaisePropertyChanged()
        {

        }
    }
}
