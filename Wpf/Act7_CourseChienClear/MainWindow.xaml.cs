using Act7_CourseChien.POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace Act7_CourseChienClear
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Chien[] chiensCourreurs = new Chien[4];
            SetupDog(ref chiensCourreurs);
        }


        public void SetupDog(ref Chien[] chiensCourreurs)
        {

                int[] coordonees = new int[2];
                coordonees[0] = 23;
                coordonnees[1] = 

            for (int i = 0; i < 4; i++)
            {
                BitmapImage imageChien = new BitmapImage();
                imageChien.BeginInit();
                imageChien.UriSource = new Uri("Asset/dog.png", UriKind.Relative);
                imageChien.EndInit();
                Image imageDog = new Image();
                imageDog.Source = imageChien;
                imageDog.Stretch = System.Windows.Media.Stretch.None;


                chiensCourreurs[i] = new Chien[593, (i + 1), imageDog, 59, false];
            }
        }
    }
}
