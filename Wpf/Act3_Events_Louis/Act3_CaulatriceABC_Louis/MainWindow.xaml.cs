using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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

namespace Act3_CaulatriceABC_Louis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BtnCalculer.MouseEnter += new MouseEventHandler(Survol_Bouton);

            TxtA.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TxtB.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TxtC.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            BtnCalculer.Click += new RoutedEventHandler(BtnCalculer_Click);





        }

        public void Survol_Bouton (object sender, MouseEventArgs e)
        {
            BtnV.Visibility = Visibility.Visible;
            BtnV.Background = Brushes.Red;
        }

        public void VerifTextInput (object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "," && !EstEntier(e.Text))
            {
                e.Handled = true;
            } else if (e.Text == ",") 
            {
                if (((TextBox)sender).Text.IndexOf(e.Text)>-1) {
                    e.Handled = true;
                }
            }
        }

        private bool EstEntier(string texteUser)
        {
            int n;

            if (int.TryParse(texteUser, out n))
            {
                return true;
            } else
            {
                return false;
            }
        }
        private void BtnCalculer_Click(object sender, RoutedEventArgs e)
        {
            MethodesDuProjet mesOutils = new MethodesDuProjet();
            int a;
            int b;
            int c;
            int x1;
            int x2;
            string type;

            a = Convert.ToInt32(TxtA.Text);
            b = Convert.ToInt32(TxtB.Text);
            c = Convert.ToInt32(TxtC.Text);


            mesOutils.ResoudreTrinome(a, b, c, out x1, out x2, out type);
            PageResultat pageResultat = new PageResultat(); 
            pageResultat.resultat.Text = type;
            pageResultat.Show();
        }
    }
}
