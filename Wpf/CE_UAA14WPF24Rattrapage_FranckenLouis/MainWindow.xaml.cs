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

namespace CE_UAA14WPF24Rattrapage_FranckenLouis
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            groupBoxTaille.Visibility = Visibility.Hidden;


            // EVENTS
            buttonRadioBandeLaterale.Checked += ButtonRadioBandeLaterale_Checked;
            buttonRadioBandeLaterale.Unchecked += ButtonRadioBandeLaterale_Unchecked;
            buttonRadioSolitaire.Checked += ButtonRadioSolitaire_Checked;
            buttonRadioMarelle.Checked += ButtonRadioMarelle_Checked;
            inputLignes.PreviewTextInput += InputLignes_PreviewTextInput;
            inputColonnes.PreviewTextInput += InputColonnes_PreviewTextInput;
            buttonValidate.Click += ButtonValidate_Click(inputLignes, inputColonnes, textFooter, ref caseCreux);
            caseCreux.Click += ButtonCaseCreux;



        }

        private void ButtonRadioBandeLaterale_Checked(object sender, RoutedEventArgs e)
        {
            groupBoxTaille.Visibility = Visibility.Visible;
        }

        private void ButtonRadioBandeLaterale_Unchecked(object sender, RoutedEventArgs e)
        {
            groupBoxTaille.Visibility = Visibility.Hidden;
        }

        private void ButtonRadioSolitaire_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                gridMain.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 9; i++)
            {
                gridMain.ColumnDefinitions.Add(new ColumnDefinition());
            }
            // Bande du milieu
            for (int k = 0; k < 9; k++)
            {
                for (int j = 4; j < 7; j++)
                {
                    BitmapImage imageBouton = new BitmapImage();
                    imageBouton.BeginInit();
                    imageBouton.UriSource = new Uri("/Asset/petitCercleRouge.png", UriKind.Relative);
                    imageBouton.EndInit();
                    Image imBouton = new Image();
                    imBouton.Source = imageBouton;
                    imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                    Button caseSolitaire = new Button();
                    caseSolitaire.Content = imBouton;
                    caseSolitaire.Width = 50;
                    caseSolitaire.Height = 50;

                    Grid.SetColumn(caseSolitaire, k);
                    Grid.SetRow(caseSolitaire, j);
                    gridMain.Children.Add(caseSolitaire);


                }
     
            }
            // 3x3 en haut
            for (int i = 3; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    BitmapImage imageBouton = new BitmapImage();
                    imageBouton.BeginInit();
                    imageBouton.UriSource = new Uri("/Asset/petitCercleRouge.png", UriKind.Relative);
                    imageBouton.EndInit();
                    Image imBouton = new Image();
                    imBouton.Source = imageBouton;
                    imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                    Button caseSolitaire = new Button();
                    caseSolitaire.Content = imBouton;
                    caseSolitaire.Width = 50;
                    caseSolitaire.Height = 50;

                    Grid.SetColumn(caseSolitaire, i);
                    Grid.SetRow(caseSolitaire, j);
                    gridMain.Children.Add(caseSolitaire);
                }
            }
            // 3x3 en bas
            for (int i = 3; i < 6; i++)
            {
                for (int j = 6; j < 9; j++)
                {
                    BitmapImage imageBouton = new BitmapImage();
                    imageBouton.BeginInit();
                    imageBouton.UriSource = new Uri("/Asset/petitCercleRouge.png", UriKind.Relative);
                    imageBouton.EndInit();
                    Image imBouton = new Image();
                    imBouton.Source = imageBouton;
                    imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                    Button caseSolitaire = new Button();
                    caseSolitaire.Content = imBouton;
                    caseSolitaire.Width = 50;
                    caseSolitaire.Height = 50;

                    Grid.SetColumn(caseSolitaire, i);
                    Grid.SetRow(caseSolitaire, j);
                    gridMain.Children.Add(caseSolitaire);
                }
            }

        }

        private void ButtonRadioMarelle_Checked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                gridMain.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 7; i++)
            {
                gridMain.ColumnDefinitions.Add(new ColumnDefinition());
            }
            // Diagonale Gauche haut, vers droit bas
            for (int i = 0; i < 7; i++)
            {
                int b = 0;
                if (i != 3 && b != 3)
                {
                    BitmapImage imageBouton = new BitmapImage();
                    imageBouton.BeginInit();
                    imageBouton.UriSource = new Uri("/Asset/petitCercleRouge.png", UriKind.Relative);
                    imageBouton.EndInit();
                    Image imBouton = new Image();
                    imBouton.Source = imageBouton;
                    imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                    Button caseMarelle = new Button();
                    caseMarelle.Content = imBouton;
                    caseMarelle.Width = 50;
                    caseMarelle.Height = 50;

                    Grid.SetColumn(caseMarelle, b);
                    Grid.SetRow(caseMarelle, i);
                    gridMain.Children.Add(caseMarelle);
                }

                b++;
            }
            // Diagonale gauche bas vers droite haut
            for (int i = 0; i < 7; i++)
            {
                int b = 7;
                if (i != 3 && b != 3)
                {
                    BitmapImage imageBouton = new BitmapImage();
                    imageBouton.BeginInit();
                    imageBouton.UriSource = new Uri("/Asset/petitCercleRouge.png", UriKind.Relative);
                    imageBouton.EndInit();
                    Image imBouton = new Image();
                    imBouton.Source = imageBouton;
                    imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                    Button caseMarelle = new Button();
                    caseMarelle.Content = imBouton;
                    caseMarelle.Width = 50;
                    caseMarelle.Height = 50;

                    Grid.SetColumn(caseMarelle, b);
                    Grid.SetRow(caseMarelle, i);
                    gridMain.Children.Add(caseMarelle);
                }

                b--;
            }

            // Diagonale horizontale
            for (int i = 0; i < 7; i++)
            {
                int b = 3;
                if (i != 3 && b != 3)
                {
                    BitmapImage imageBouton = new BitmapImage();
                    imageBouton.BeginInit();
                    imageBouton.UriSource = new Uri("/Asset/petitCercleRouge.png", UriKind.Relative);
                    imageBouton.EndInit();
                    Image imBouton = new Image();
                    imBouton.Source = imageBouton;
                    imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                    Button caseMarelle = new Button();
                    caseMarelle.Content = imBouton;
                    caseMarelle.Width = 50;
                    caseMarelle.Height = 50;

                    Grid.SetColumn(caseMarelle, b);
                    Grid.SetRow(caseMarelle, i);
                    gridMain.Children.Add(caseMarelle);
                }

                b++;
            }

            // Diagonale verticale
            for (int i = 0; i < 7; i++)
            {
                int b = 3;
                if(i !=3 && b != 3)
                {
                    BitmapImage imageBouton = new BitmapImage();
                    imageBouton.BeginInit();
                    imageBouton.UriSource = new Uri("/Asset/petitCercleRouge.png", UriKind.Relative);
                    imageBouton.EndInit();
                    Image imBouton = new Image();
                    imBouton.Source = imageBouton;
                    imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                    Button caseMarelle = new Button();
                    caseMarelle.Content = imBouton;
                    caseMarelle.Width = 50;
                    caseMarelle.Height = 50;

                    Grid.SetColumn(caseMarelle, i);
                    Grid.SetRow(caseMarelle, b);
                    gridMain.Children.Add(caseMarelle);
                }

                b++;
            }


        }

        private void InputLignes_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(!int.TryParse(e.Text, out _))
            {
                e.Handled = true;
            }
        }

        private void InputColonnes_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out _))
            {
                e.Handled = true;
            }
        }

        private void ButtonValidate_Click(object sender, RoutedEventArgs e, TextBox inputLignes, TextBox inputColonnes, TextBlock textFooter, ref Button caseCreux)
        {
            caseCreux = new Button();
            string ligne = inputLignes.Text;
            string colonne = inputColonnes.Text;
            int nombreLignes = Convert.ToInt32(ligne);
            int nombreColonnes = Convert.ToInt32(colonne);
            if(nombreLignes == null)
            {
                textFooter.Text = "Veuillez encoder un chiffre entre 2 et 12 pour les lignes";
            } else if(inputColonnes == null)
            {
                textFooter.Text = "Veuillez encoder un chiffre entre 2 et 12 pour les colonnes";
            } else if(nombreLignes < 2 || nombreLignes > 12 || nombreColonnes < 2 || nombreColonnes > 12)
            {
                textFooter.Text = "ERREUR ! Veuillez encoder correctement les dimensions comprenant entre 2 et 12 !";
            } else
            {
                for (int k = 0; k < nombreColonnes; k++)
                {
                    caseCreux = new Button();
                    caseCreux.Content = "X";
                    caseCreux.Foreground = Brushes.Red;
                    caseCreux.FontWeight = FontWeights.Bold;
                    caseCreux.FontSize = 22;
                    caseCreux.Width = 50;
                    caseCreux.Height = 50;

                    Grid.SetColumn(caseCreux, 0);
                    Grid.SetRow(caseCreux, k);
                    gridMain.Children.Add(caseCreux);

                }

                for (int k = 1; k < nombreLignes - 1; k++)
                {
                    caseCreux = new Button();
                    caseCreux.Content = "X";
                    caseCreux.Foreground = Brushes.Red;
                    caseCreux.FontWeight = FontWeights.Bold;
                    caseCreux.FontSize = 22;
                    caseCreux.Width = 50;
                    caseCreux.Height = 50;

                    Grid.SetColumn(caseCreux, k);
                    Grid.SetRow(caseCreux, nombreColonnes);
                    gridMain.Children.Add(caseCreux);

                }

                for (int k = 0; k < nombreColonnes; k++)
                {
                    caseCreux = new Button();
                    caseCreux.Content = "X";
                    caseCreux.Foreground = Brushes.Red;
                    caseCreux.FontWeight = FontWeights.Bold;
                    caseCreux.FontSize = 22;
                    caseCreux.Width = 50;
                    caseCreux.Height = 50;

                    Grid.SetColumn(caseCreux, nombreLignes);
                    Grid.SetRow(caseCreux, k);
                    gridMain.Children.Add(caseCreux);

                }

                for (int k = 1; k < nombreLignes; k++)
                {
                    caseCreux = new Button();
                    caseCreux.Content = "X";
                    caseCreux.Foreground = Brushes.Red;
                    caseCreux.FontWeight = FontWeights.Bold;
                    caseCreux.FontSize = 22;
                    caseCreux.Width = 50;
                    caseCreux.Height = 50;

                    Grid.SetColumn(caseCreux, k);
                    Grid.SetRow(caseCreux, 0);
                    gridMain.Children.Add(caseCreux);

                }


            }

            private void ButtonValidate_Click(object sender, RoutedEventArgs e)
            {
                caseCreux.Background = Brushes.Khaki;
            }
        }
    }
}
