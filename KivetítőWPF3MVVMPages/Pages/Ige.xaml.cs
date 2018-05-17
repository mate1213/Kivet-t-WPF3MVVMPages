using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KivetítőWPF3MVVMPages
{
    /// <summary>
    /// Interaction logic for Ige.xaml
    /// </summary>
    public partial class Ige : Page
    {
        public ViewModel.ViewModelLocator Adatok { get; set; }

        public Ige()
        {
            Adatok = new ViewModel.ViewModelLocator();
            InitializeComponent();
        }

        private void CsakSzam_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox tb = sender as TextBox;
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void MaxErtek_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            TextBox tb = sender as TextBox;
            int inttemp;
            bool booltemp = int.TryParse(tb.Text, out inttemp);
            if (inttemp > 250)
            {
                MessageBox.Show("Nagyobb szám nem elfogadott! Max:250", "Hiba!");
                tb.Text = "";
            }
        }
    }
}
