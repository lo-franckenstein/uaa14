using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Act4a_CreationDynamique_Louis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            preparationGrillage();



        }
        public void preparationGrillage()
        {
            // Création du tableau
            ColumnDefinition[] coldef = new ColumnDefinition[3];
            RowDefinition[] rowDef = new RowDefinition[3];
            for (int i = 0; i < 3; i++)
            {
                coldef[i] = new ColumnDefinition();
                rowDef[i] = new RowDefinition();

                grdMain.ColumnDefinitions.Add(coldef[i]);
                grdMain.RowDefinitions.Add(rowDef[i]);
            }


            // Placement de la première bande jaune
            TextBlock txtFirst = new TextBlock();
            txtFirst.Text = "TextBlock créé dynamiquement";
            txtFirst.FontSize = 60;
            txtFirst.FontWeight = FontWeights.Bold;
            txtFirst.Foreground = Brushes.Red;
            txtFirst.Background = Brushes.Yellow;
            Grid.SetRow(txtFirst, 0);
            Grid.SetColumnSpan(txtFirst, 3);
            grdMain.Children.Add(txtFirst);




            // Placement de la deuxième bande
            Button[] suiteButton = new Button[3];
            for (int i = 0; i < 3; i++)
            {
                suiteButton[i] = new Button();
                suiteButton[i].Height = 80;
                suiteButton[i].Width = 80;
                suiteButton[i].Content = "BOUTON " + (i + 1);
                Grid.SetColumn(suiteButton[i], i);
                Grid.SetRow(suiteButton[i], 1);
                grdMain.Children.Add(suiteButton[i]);
            }

            // Placement de la troisième bande
            TextBlock txtSecond = new TextBlock();
            txtSecond.Text = "infos:";
            txtSecond.FontSize = 20;
            txtSecond.FontWeight = FontWeights.Bold;
            txtSecond.Foreground = Brushes.Black;
            txtSecond.Background = Brushes.Yellow;
            Grid.SetRow(txtSecond, 2);
            Grid.SetColumnSpan(txtSecond, 2);
            grdMain.Children.Add(txtSecond);
            TextBlock txtThird = new TextBlock();
            txtThird.Height = 50;
            txtThird.Text = "J'attends vos infos";
            txtThird.FontSize = 20;
            txtThird.Foreground = Brushes.Black;
            txtThird.Background = Brushes.White;
            Grid.SetRow(txtThird, 2);
            Grid.SetColumnSpan(txtThird, 2);
            grdMain.Children.Add(txtThird);
            ComboBox optionsDiff = new ComboBox();
            optionsDiff.Items.Add("Information 1");
            optionsDiff.Items.Add("Information 2");
            optionsDiff.VerticalAlignment = VerticalAlignment.Center;
            optionsDiff.HorizontalAlignment = HorizontalAlignment.Center;
            optionsDiff.Height = 90;
            optionsDiff.Width = 130;
            Grid.SetRow(optionsDiff, 3);
            Grid.SetColumn(optionsDiff, 3);
            grdMain.Children.Add(optionsDiff);















        }

    }
}