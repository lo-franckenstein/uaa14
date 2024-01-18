using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Windows.Threading;

namespace MatchingGame_LouisFrancken
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        TextBlock derniereTBClique; // on va l’utiliser pour faire une référence à  la TextBlock sur laquelle on vient de cliquer


        public MainWindow()
        {

            InitializeComponent();
            SetUpGame();

        }
        private void SetUpGame()
        {

            // Création du tableau
            ColumnDefinition[] columnDef = new ColumnDefinition[4];
            RowDefinition[] rowDef = new RowDefinition[4];
            TextBlock[,] textCase = new TextBlock[4, 4];
            for (int i = 0; i < 4; i++)
            {
                columnDef[i] = new ColumnDefinition();
                grdMain.ColumnDefinitions.Add(columnDef[i]);
                rowDef[i] = new RowDefinition();
                grdMain.RowDefinitions.Add(rowDef[i]);
            }

            // Placement des cases
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    textCase[i, j] = new TextBlock();
                    textCase[i, j].HorizontalAlignment = HorizontalAlignment.Center;
                    textCase[i, j].VerticalAlignment = VerticalAlignment.Center;
                    textCase[i, j].FontSize = 50;
                    textCase[i, j].MouseDown += TextBlock_MouseDown;
                    textCase[i, j].Text = "?";
                    // Placer précisément
                    Grid.SetRow(textCase[i, j], i);
                    Grid.SetColumn(textCase[i, j], j);
                    grdMain.Children.Add(textCase[i, j]);
                }
            }
        }


        // Evènement clique
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlockActif = sender as TextBlock;
            textBlockActif.Text = "X";
            derniereTBClique = textBlockActif;
        }
    }
}
