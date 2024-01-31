using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_ExEntreprise
{
    class generateurInformation
    {
        public string GetRandomName()
        {
            string nameFinal;
            string[] names = { "Louis", "Adam", "Victor", "Tom", "Aymeric", "Alexandre", "Sefedin", "Nathan", "Guillaume", "Jayson", "Elias", "Romane", "Ewan", "Noha" };
            Random random = new Random();
            int randomIndex = random.Next(names.Length);
            nameFinal = Convert.ToString(names[randomIndex]);
            return nameFinal;
        }

        public string GetRandomSurName()
        {
            string nameFinal;
            string[] names = { "Francken", "Essalhi", "Pholien", "Rijckaert", "Marsigny", "Grégoire", "Adjini", "Massart", "Collin", "Evrard", "Cara", "Grootaers", "Ramsamy", "Verbist" };
            Random random = new Random();
            int randomIndex = random.Next(names.Length);
            nameFinal = Convert.ToString(names[randomIndex]);
            return nameFinal;
        }

        public int GetRandomMatricule()
        {
            int matriculeRandom = 0;
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                matriculeRandom += random.Next(0, 9);
            }
            return matriculeRandom;
        }

        public DateTime GetRandomDate()
        {
            DateTime startDate = new DateTime(2000, 1, 1);
            Random random = new Random();


            int randomDays = random.Next(1, 3650);

            // Ajoute le nombre de jours aléatoire à la date de départ
            DateTime randomDateTime = startDate.AddDays(randomDays);
            return randomDateTime;
        }

        public int GetRandomCA()
        {
            Random random = new Random();
            int randomCa = random.Next(500000, 908456515);
            return randomCa;
        }

        public int GetRandomPourcentage()
        {
            Random random = new Random();
            int randomPourcentage = random.Next(1, 99);
            return randomPourcentage;
        }
    }
}
