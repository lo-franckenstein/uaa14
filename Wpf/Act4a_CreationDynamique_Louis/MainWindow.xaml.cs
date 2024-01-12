using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
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
            ColumnDefinition[] colDef = new ColumnDefinition[3];
            for (int i = 0; i < 3; i++)
            {
                colDef[i] = new ColumnDefinition();
            }

            // Colonnes
            for (int i = 0; i < 3; i++)
            {
                grdMain.ColumnDefinitions.Add(colDef[i]);
            }

            RowDefinition[] rowDef = new RowDefinition[3];

            for (int i = 0; i < 3; i++)
            {
                rowDef[i] = new RowDefinition();
            }

            // Lignes
            for(int i = 0;i < 3; i++)
            {
                grdMain.RowDefinitions.Add(rowDef[i]);
            }

            for (int i = 0; i < 3; i++)
            {
                tableau[i, 1] = new Button();
                Thickness myThickness = new Thickness();
                myThickness.Bottom = 20;
                myThickness.Left = 20;
                myThickness.Right = 20;
                myThickness.Top = 20;
                tableau[i, 1].Margin = myThickness;
                tableau[i, 1].Content = "Bouton" + (i + 1);

            }

            TextBlock mainText = new TextBlock();

            grdMain.SetRow(mainText, 0);
            grdMain.SetRow(mainText, 0);
            grdMain.SetRowSpan(mainText, 3);




        }

    }
}