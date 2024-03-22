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

namespace CE_UAA14WPF24_FranckenLouis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow(RadioButton buttonSolitaire)
        {
            InitializeComponent();
        }




        private void buttonBandeLateraleCheck(object sender, RoutedEventArgs e)
        {
            if(buttonBandeLaterale.IsChecked == true)
            {
                SetupMain();
            } else
            {
                RemoveMain();
            }
        }
        private void RemoveMain()
        {
            textTaillePlateau.Opacity = 0;
            inputColonnes.Opacity = 0;
            inputLignes.Opacity = 0;
        }

        private void SetupMain()
        {
            textTaillePlateau.Opacity = 1;
            inputColonnes.Opacity = 1;
            inputLignes.Opacity = 1;
        }

        private void imBoutton_Click(object sender, RoutedEventArgs e)
        {
            imBouton.UriSource = new Uri("./assets/volvik", UriKind.Relative);
        }

        private void buttonValidate_Click(object sender, RoutedEventArgs e)
        {
            if(buttonSolitaire.IsChecked == true)
            {
                ColumnDefinition[] columnDef = new ColumnDefinition[9];
                RowDefinition[] rowDefinitions = new RowDefinition[9];

                for (int i = 0; i < 9; i++)
                {
                    columnDef[i] = new ColumnDefinition();
                    rowDefinitions[i] = new RowDefinition();
                    secondRowMain.ColumnDefinitions.Add(columnDef[i]);
                    secondRowMain.RowDefinitions.Add(rowDefinitions[i]);
                }

                // Colonne du centre
                for (int j = 3; j < 4; j++)
                {
                    for (int i = 0; i < 9; i++)
                    {

                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("./assets/petitCercleRouge", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                        Grid.SetRow(imBouton, i);
                        Grid.SetColumn(imBouton, j);
                        secondRowMain.Children.Add(imBouton);

                    }
                }

                // 3x3 du gauche
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 3; i < 5; i++)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("./assets/petitCercleRouge", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                        Grid.SetRow(imBouton, i);
                        Grid.SetColumn(imBouton, j);
                        secondRowMain.Children.Add(imBouton);
                    }
                }

                //3x3 de droite
                for (int j = 6; j < 9; j++)
                {
                    for (int i = 3; i < 5; i++)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("./assets/petitCercleRouge", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                        Grid.SetRow(imBouton, i);
                        Grid.SetColumn(imBouton, j);
                        secondRowMain.Children.Add(imBouton);
                    }
                }


            } else if(buttonBandeLaterale.IsChecked == true)
            {
                if(inputColonnes && inputLignes)
                {
                    if(inputColonnes >= 2 && inputColonnes <= 12 && inputLignes >= 2 && inputColonnes <= 12)
                    {
                        ColumnDefinition[] columnDef = new ColumnDefinition[inputColonnes];
                        RowDefinition[] rowDefinitions = new RowDefinition[inputLignes];

                        for (int i = 0; i < inputLignes; i++)
                        {
                            rowDefinitions[i] = new RowDefinition();
                            secondRowMain.RowDefinitions.Add(rowDefinitions[i]);
                        }

                        for (int i = 0; i < inputColonnes; i++)
                        {
                            columnDef[i] = new ColumnDefinition();
                            secondRowMain.ColumnDefinition.Add(rowDefinitions[i]);
                        }

                        // Placement Ligne verticale max
                        for (int i = 0; i < inputColonnes; i++)
                        {
                            BitmapImage imageBouton = new BitmapImage();
                            imageBouton.BeginInit();
                            imageBouton.UriSource = new Uri("./assets/petitCercleRouge", UriKind.Relative);
                            imageBouton.EndInit();
                            Image imBouton = new Image();
                            imBouton.Source = imageBouton;
                            imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                            Grid.SetRow(imBouton, 0);
                            Grid.SetColumn(imBouton, i);
                            secondRowMain.Children.Add(imBouton);
                        }

                        // Placement Colonne Gauche
                        for (int i = 0; i < inputRows; i++)
                        {
                            BitmapImage imageBouton = new BitmapImage();
                            imageBouton.BeginInit();
                            imageBouton.UriSource = new Uri("./assets/petitCercleRouge", UriKind.Relative);
                            imageBouton.EndInit();
                            Image imBouton = new Image();
                            imBouton.Source = imageBouton;
                            imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                            Grid.SetRow(imBouton, i);
                            Grid.SetColumn(imBouton, inputColonnes);
                            secondRowMain.Children.Add(imBouton);
                        }

                        // Placement Colonne Droite
                        for (int i = 0; i < inputRows; i++)
                        {
                            BitmapImage imageBouton = new BitmapImage();
                            imageBouton.BeginInit();
                            imageBouton.UriSource = new Uri("./assets/petitCercleRouge", UriKind.Relative);
                            imageBouton.EndInit();
                            Image imBouton = new Image();
                            imBouton.Source = imageBouton;
                            imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                            Grid.SetRow(imBouton, i);
                            Grid.SetColumn(imBouton, 0);
                            secondRowMain.Children.Add(imBouton);
                        }

                        // Placement Colonne Gauche
                        for (int i = 0; i < inputColumn+)
                        {
                            BitmapImage imageBouton = new BitmapImage();
                            imageBouton.BeginInit();
                            imageBouton.UriSource = new Uri("./assets/petitCercleRouge", UriKind.Relative);
                            imageBouton.EndInit();
                            Image imBouton = new Image();
                            imBouton.Source = imageBouton;
                            imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                            Grid.SetRow(imBouton, i);
                            Grid.SetColumn(imBouton, inputColonnes);
                            secondRowMain.Children.Add(imBouton);
                        }



                    } else
                    {
                        textUnderground.Text = "Veuillez encoder des dimensions valides comprises entre 2 et 12";
                    }
                } else
                {
                    textUnderground.Text = "Votre colonne/ligne est vide";
                }
            }
        }

        }
    }
}
