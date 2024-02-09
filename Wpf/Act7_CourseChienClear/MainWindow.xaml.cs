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
            Parieur[] joueursPari = new Parieur[3];
            SetupPari(ref joueursPari);
        }


        public void SetupDog(ref Chien[] chiensCourreurs)
        {
                int[] coordonees = new int[2];
                coordonees[0] = 65;
                coordonees[1] = 18;

            for (int i = 0; i < 4; i++)
            {
                BitmapImage imageChien = new BitmapImage();
                imageChien.BeginInit();
                imageChien.UriSource = new Uri("Asset/dog.png", UriKind.Relative);
                imageChien.EndInit();
                Image imageDog = new Image();
                imageDog.Source = imageChien;
                imageDog.Stretch = System.Windows.Media.Stretch.None;

                int numeroplace = i + 1;
                chiensCourreurs[i] = new Chien(593, numeroplace, imageDog, coordonees, false);

                Canvas.SetLeft(imageDog, coordonees[0]);
                Canvas.SetTop(imageDog, coordonees[1]);
                piste.Children.Add(imageDog);


                coordonees[1] += 70;
            }
        }

        public void SetupPari(ref Parieur[] joueursPari)
        {
            for (int i = 0; i < 3; i++)
            {
                string prenom;
                TextBlock setupEtatPari;
                switch (i)
                {
                    case 0:
                        prenom = "Joe";
                        setupEtatPari = EtatPariJoe;
                        break;
                    case 1:
                        prenom = "Bob";
                        setupEtatPari = EtatPariBob
                        break;
                    case 2:
                        prenom = "Bill";
                        setupEtatPari = EtatPariBill;
                        break;
                    default:
                        break;
                }
                
                joueursPari[i] = new Chien(prenom, , 50, "n'a pas encore parié");
            }
        }

    }
}
