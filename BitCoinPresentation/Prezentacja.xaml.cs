using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BitCoin_Presentation
{
    /// <summary>
    /// Interaction logic for Prezentacja.xaml
    /// </summary>
    public partial class Prezentacja : Window
    {
        public Prezentacja()
        {
            InitializeComponent();

            
        }

        private void Presentation_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.Current.MainWindow.Close();
        }
    }
}
