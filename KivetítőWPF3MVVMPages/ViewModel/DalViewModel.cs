using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace KivetítőWPF3MVVMPages.ViewModel
{
    public class DalViewModel : ViewModelBase
    {
        public ViewModelLocator Locator { get; set; }

        public DalViewModel()
        {
            Locator = new ViewModelLocator();

            #region RelayCommand Declaration

            TextBoxKeresGotFocusCommand = new RelayCommand<object>(TextBoxKeresGotFocus);
            TextBoxKeresLostFocusCommand = new RelayCommand<object>(TextBoxKeresLostFocus);

            #endregion
        }

        #region RelayCommands

        #region Property

        public RelayCommand<object> TextBoxKeresGotFocusCommand { get; set; }
        public RelayCommand<object> TextBoxKeresLostFocusCommand { get; set; }

        #endregion

        #region Method

        private void TextBoxKeresGotFocus(object sender)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "Itt kereshetsz a dalok között.")
            {
                tb.Text = string.Empty;
                tb.Foreground = Brushes.Black;
            }
        }

        private void TextBoxKeresLostFocus(object sender)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "")
            {
                tb.Text = "Itt kereshetsz a dalok között.";
                var bc = new BrushConverter();
                tb.Foreground = (Brush)bc.ConvertFrom("#FF7A7A7A");
            }
        }

        #endregion

        #endregion

    }
}
