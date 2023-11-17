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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UAA14_I3_LouisFrancken
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Vérif des frappes sur le clavier dans les deux zones de textes

            TextN1.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TextN2.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);

            // Boutton Reset
            BtnReset.Click += new RoutedEventHandler(BtnReset_Click);


            // Bouton Calculer
            BtnCalculer.Click += new RoutedEventHandler(BtnCalculer_Click);



        }

        public void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            if(e.Text != "1" || e.Text != "0")
            {
                
            }

        }

        public void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            TextN1.Text = "";
            TextN2.Text= "";
        }

        private void BtnCalculer_Click(object sender, RoutedEventArgs e)
        {
            MethodesDuProjet mesOutils = new MethodesDuProjet();


            string nombreBinaire;
            ushort[] t1;
            ushort[] t2;
            ushort[] tRes;
            bool ok;
            string resultat;

            nombreBinaire = Convert.ToString(TextN1.Text);
            t1 = mesOutils.RemplirTableau(nombreBinaire);

            nombreBinaire = Convert.ToString(TextN1.Text);
            t2 = mesOutils.RemplirTableau(nombreBinaire);


            if (RadioAddition.IsChecked == true)
            {

                mesOutils.Additionne(t1, t2, out tRes, out ok);
                if (ok)
                {
                    resultat = mesOutils.Concatene(tRes);
                    TextResult.Text = "Résultat de l'opération: " + resultat;
                } else
                {
                    MessageBox.Show("Le calcul n'a pas pû se faire car vous n'avez pas respecter la taille des nombres...");
                }

            } else if (RadioSoustraction.IsChecked == true)
            {
                ok = mesOutils.Soustrait(t1, t2, out tRes);
                if (ok)
                {
                    resultat = mesOutils.Concatene(tRes);
                    TextResult.Text = "Résultat de l'opération: " + resultat;
                }
                else
                {
                    MessageBox.Show("Le calcul n'a pas pû se faire car vous n'avez pas respecter la taille des nombres...");
                }


            } else
            {
                // Message d'erreur, au cas où
                MessageBox.Show("Le programme a planté, car aucune opération n'a été choisie");
            }
        }


    }
}
