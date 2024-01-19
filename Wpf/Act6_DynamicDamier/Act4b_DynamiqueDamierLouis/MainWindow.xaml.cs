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

namespace Act4b_DynamiqueDamierLouis
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
            ColumnDefinition[] columnDef = new ColumnDefinition[10];
            RowDefinition[] rowDef = new RowDefinition[10];
            Button[,] textCase = new Button[10, 10];
            for (int i = 0; i < 10; i++)
            {
                columnDef[i] = new ColumnDefinition();
                grdMain.ColumnDefinitions.Add(columnDef[i]);
                rowDef[i] = new RowDefinition();
                grdMain.RowDefinitions.Add(rowDef[i]);
            }
            int numero;
            numero = 1;
            // Ajout case
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
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
                            textCase[i, j].Background = Brushes.Black;
                        }
                        else
                        {
                            textCase[i, j].Background = Brushes.White;
                        }
                    }
                    else
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
                    // Boucle pour les numéros
                    if (i%2 == 0)
                    {
                        if(j == 0)
                        {
                            if (i != 0)
                            {
                                numero = numero + 10;
                            }
                        }
                        textCase[i, j].Content = numero.ToString();
                        numero++;
                    } else
                    {
                        if(j == 0)
                        {
                            numero = numero + 10;
                        }
                        textCase[i, j].Content = (numero - 1).ToString();
                        numero--;
                        
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