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

namespace Act3_CaulatriceABC_Louis
{
    /// <summary>
    /// Logique d'interaction pour PageResultat.xaml
    /// </summary>
    public partial class PageResultat : Window
    {
        public PageResultat()
        {
            InitializeComponent();
            BtnReturn.Click += new RoutedEventHandler(BtnReturn_Click);
        }

        public void BtnReturn_Click (object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
