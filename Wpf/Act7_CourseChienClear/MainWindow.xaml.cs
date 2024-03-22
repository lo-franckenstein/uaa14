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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

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
            // Parieur[] joueursPari = new Parieur[3];
            // SetupPari(ref joueursPari);

            Random alea = new Random();
            StartRaceAsync(chiensCourreurs, alea);
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




        public async Task StartRaceAsync(Chien[] chiensCourreurs, Random alea)
        {
            bool raceEnd = false;
            int caseChien = 0;
            int[] tableauChienTemporaire;

            do
            {
                raceEnd = true;

                for (int i = 0; i < 4; i++)
                {
                    tableauChienTemporaire = chiensCourreurs[i].PositionCourante;
                    caseChien = alea.Next(0, 100);

                    int variableForIf = tableauChienTemporaire[0] + caseChien;

                    if (variableForIf < 728) // SI UN CHIEN N'A PAS FINI LA COURSE
                    {
                        tableauChienTemporaire[0] = tableauChienTemporaire[0] + caseChien;
                        chiensCourreurs[i].PositionCourante = tableauChienTemporaire;

                        DoubleAnimation animationX = new DoubleAnimation();
                        animationX.To = tableauChienTemporaire[0];
                        animationX.Duration = TimeSpan.FromSeconds(0.5);

                        // Attendre la fin de l'animation
                        chiensCourreurs[i].ImageChien.BeginAnimation(Canvas.LeftProperty, animationX);

                        raceEnd = false; // Met à jour raceEnd puisque la course n'est pas terminée
                    }
                    else // SI UN CHIEN A FINI LA COURSE
                    {
                        tableauChienTemporaire[0] = 728;
                        chiensCourreurs[i].PositionCourante = tableauChienTemporaire;
                        chiensCourreurs[i].Gagne = true;

                        DoubleAnimation animationX = new DoubleAnimation();
                        animationX.To = tableauChienTemporaire[0];
                        animationX.Duration = TimeSpan.FromSeconds(0.5);

                        // Attendre la fin de l'animation
                        chiensCourreurs[i].ImageChien.BeginAnimation(Canvas.LeftProperty, animationX);
                    }

                    await Task.Delay(500); // Attendre avant de déplacer le prochain chien
                }
            } while (!raceEnd);

            // Une fois la course terminée, afficher les MessageBox
            string messageChienGagnant = "Le Chien " + VerificationChienGagnant(chiensCourreurs) + " a gagné la course !";
            string messageParieurGagnant = " est/sont les gagnants du pari de cette course !";
            MessageBox.Show(messageChienGagnant);
            MessageBox.Show(messageParieurGagnant);
        }


        public int VerificationChienGagnant(Chien[] chiensCourreurs)
        {
            int chienGagnant = 0;
            if (chiensCourreurs[0].Gagne == true)
            {
                chienGagnant = 1;
            } else if (chiensCourreurs[1].Gagne == true)
            {
                chienGagnant = 2;
            } else if (chiensCourreurs[2].Gagne == true)
            {
                chienGagnant = 3;
            } else { 
                chienGagnant = 4;
            }
            return chienGagnant;
        }


    }
}
