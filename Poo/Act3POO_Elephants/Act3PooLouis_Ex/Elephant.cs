using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Act3PooLouis_Ex
{
    class Elephant
    {
        private string _nom;
        private uint _tailleOreille;
        public Elephant(string nom, uint tailleOreille)
        {
            _nom = nom;
            _tailleOreille = tailleOreille;
        }

        public string affichequisuisje()
        {
            string phrase = "Je m'appelle " + _nom + ".\nMes oreilles mesurent " + _tailleOreille + "cm.";
            Console.WriteLine(phrase); return phrase;
        }

        public void EcouteMessage(string message, Elephant quiDit)
        {
            Console.WriteLine(_nom + " a entendu un message \n" + quiDit._nom + " a dit : " + message);
        }

        public void EnvoieMessage(string message, Elephant quiRecoit)
        {
            quiRecoit.EcouteMessage(message, this);
        }

    }

}
