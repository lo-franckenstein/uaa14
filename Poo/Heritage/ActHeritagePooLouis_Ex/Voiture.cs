using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_Ex
{
    class Voiture : Vehicule
    {

        protected string _motorisation;
        protected bool _gps;

        public string Motorisation
        {
            get { return _motorisation; }
            set { _motorisation = value; }
        }

        public bool Gps
        {
            get { return _gps; }
            set { _gps = value; }
        }

        public Voiture(string motorisation, bool gps, string marque, string modele, string couleur, decimal prix) : base(marque, modele, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }

        public string Affichage()
        {
            string boolGps = "";
            if (_gps == true)
            {
                boolGps = "possède un gps";
            }
            else
            {
                boolGps = "ne possède pas de gps";
            }

            string info = "  [+] Marque: " + _marque + "\n  [+] Modèle: " + _modele + "\n  [+] Couleur: " + _couleur + "\n  [+] Prix: " + _prix + "\n  [+] Type: " + _motorisation + "\n  [+] Le vehicule " + boolGps;
            return info;
        }
    }
}
