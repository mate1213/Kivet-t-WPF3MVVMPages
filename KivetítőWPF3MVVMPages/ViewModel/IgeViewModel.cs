using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Controls;

namespace KivetítőWPF3MVVMPages.ViewModel
{
    public class IgeViewModel : ViewModelBase
    {
        public ViewModelLocator Locator { get; set; }

        public IgeViewModel()
        {
            Locator = new ViewModelLocator();

            CsakSzamPreviewTextInputCommand = new RelayCommand<object>(CsakSzamPreviewTextInput);
        }

        #region RelayCommands

        #region Property

        public RelayCommand<object> CsakSzamPreviewTextInputCommand { get; set; }
        public RelayCommand<object> MaxErtekTextChangedCommand { get; set; }

        #endregion

        #region Method

        private void MaxErtekTextChanged(object sender)
        {

        }

        private void CsakSzamPreviewTextInput(object sender)
        {
            TextBox tb = sender as TextBox;
            int temp;
            if (tb.Text != "")
            {
                if (tb.Text.Length < 2 && !int.TryParse(tb.Text, out temp))
                {
                    tb.Text = "";
                }
                else if (!int.TryParse(tb.Text, out temp))
                {
                    tb.Text = tb.Text.Remove(tb.Text.Length - 1);
                }
            }

        }

        #endregion

        #endregion
    }
}
