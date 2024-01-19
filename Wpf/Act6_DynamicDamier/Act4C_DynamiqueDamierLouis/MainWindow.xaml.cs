using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Act4C_DynamiqueDamierLouis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetupPlateau();
        }

        private void SetupPlateau()
        {
            // Ajout tableau
            ColumnDefinition[] columnDef = new ColumnDefinition[8];
            RowDefinition[] rowDef = new RowDefinition[8];
            Button[,] textCase = new Button[8, 8];
            for (int i = 0; i < 8; i++)
            {
                columnDef[i] = new ColumnDefinition();
                grdMain.ColumnDefinitions.Add(columnDef[i]);
                rowDef[i] = new RowDefinition();
                grdMain.RowDefinitions.Add(rowDef[i]);
            }
            // Ajout case
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    textCase[i, j] = new Button();
                    textCase[i, j].HorizontalAlignment = HorizontalAlignment.Center;
                    textCase[i, j].VerticalAlignment = VerticalAlignment.Center;
                    textCase[i, j].FontSize = 30;
                    textCase[i, j].Foreground = Brushes.Red;
                    textCase[i, j].Height = 65;
                    textCase[i, j].Width = 65;
                    textCase[i, j].FontWeight = FontWeights.Bold;
                    // Condition pour les couleurs des cases
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            textCase[i, j].Background = Brushes.White;
                        }
                        else
                        {
                            textCase[i, j].Background = Brushes.Black;
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            textCase[i, j].Background = Brushes.Black;
                        }
                        else
                        {
                            textCase[i, j].Background = Brushes.White;
                        }
                    }
                    // Condition pour les images
                    if (i == 0 || i == 1)
                    {
                        BitmapImage imageBouton;
                        imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/pion.png", UriKind.Relative);
                        imageBouton.EndInit();
                        if (i == 0)
                        {
                            imageBouton = new BitmapImage();
                            imageBouton.BeginInit();
                            switch (j)
                            {
                                case 0:
                                    imageBouton.UriSource = new Uri("assets/tour.png", UriKind.Relative);
                                    break;
                                case 1:
                                    imageBouton.UriSource = new Uri("assets/cavalier.png", UriKind.Relative);
                                    break;
                                case 2:
                                    imageBouton.UriSource = new Uri("assets/fou.png", UriKind.Relative);
                                    break;
                                case 3:
                                    imageBouton.UriSource = new Uri("assets/king.png", UriKind.Relative);
                                    break;
                                case 4:
                                    imageBouton.UriSource = new Uri("assets/queen.png", UriKind.Relative);
                                    break;
                                case 5:
                                    imageBouton.UriSource = new Uri("assets/fou.png", UriKind.Relative);
                                    break;
                                case 6:
                                    imageBouton.UriSource = new Uri("assets/cavalier.png", UriKind.Relative);
                                    break;
                                case 7:
                                    imageBouton.UriSource = new Uri("assets/tour.png", UriKind.Relative);
                                    break;
                                default:
                                    imageBouton.UriSource = new Uri("assets/pion.png", UriKind.Relative);
                                    break;

                            }
                            imageBouton.EndInit();
                        } 
                        

                        
                        
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.None;
                        textCase[i, j].Content = imBouton;
                    }

                    if (i == 7 || i == 6)
                    {
                        BitmapImage imageBouton;
                        imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/pion.png", UriKind.Relative);
                        imageBouton.EndInit();
                        if (i == 7)
                        {
                            imageBouton = new BitmapImage();
                            imageBouton.BeginInit();
                            switch (j)
                            {
                                case 0:
                                    imageBouton.UriSource = new Uri("assets/tour.png", UriKind.Relative);
                                    break;
                                case 1:
                                    imageBouton.UriSource = new Uri("assets/cavalier.png", UriKind.Relative);
                                    break;
                                case 2:
                                    imageBouton.UriSource = new Uri("assets/fou.png", UriKind.Relative);
                                    break;
                                case 3:
                                    imageBouton.UriSource = new Uri("assets/king.png", UriKind.Relative);
                                    break;
                                case 4:
                                    imageBouton.UriSource = new Uri("assets/queen.png", UriKind.Relative);
                                    break;
                                case 5:
                                    imageBouton.UriSource = new Uri("assets/fou.png", UriKind.Relative);
                                    break;
                                case 6:
                                    imageBouton.UriSource = new Uri("assets/cavalier.png", UriKind.Relative);
                                    break;
                                case 7:
                                    imageBouton.UriSource = new Uri("assets/tour.png", UriKind.Relative);
                                    break;
                                default:
                                    imageBouton.UriSource = new Uri("assets/pion.png", UriKind.Relative);
                                    break;

                            }
                            imageBouton.EndInit();
                        }




                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.None;
                        textCase[i, j].Content = imBouton;
                    }



                    // Placer précisément
                    Grid.SetRow(textCase[i, j], i);
                    Grid.SetColumn(textCase[i, j], j);
                    grdMain.Children.Add(textCase[i, j]);
                }
            }


        }
    }
}