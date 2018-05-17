using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace KivetítőWPF3MVVMPages.ViewModel
{
    public class KepViewModel : ViewModelBase
    {
        private ObservableCollection<Model.Kep> _model;
        #region Property

        public ObservableCollection<Model.Kep> model { get => _model; set => _model = value; }

        #endregion

        public KepViewModel()
        {
            model = new ObservableCollection<Model.Kep>();
            //model.KepHelye.Add();
            TextBox_DoubleClickCommand = new RelayCommand(DoubleClick);
        }

        public RelayCommand TextBox_DoubleClickCommand { get; set; }

        private void DoubleClick()
        {
            OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true};
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Model.Kep temp;
                string[] fajlok = ofd.FileNames;
                foreach (var item in fajlok)
                {
                    temp = new Model.Kep();
                    temp.KepHelye = item;
                    temp.Height = 180;
                    temp.Width = 320;
                    model.Add(temp);
                }
            }
        }
    }
}
