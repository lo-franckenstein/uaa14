using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_Ex
{
    class Velo : Vehicule
    {

        protected string _type;
        protected bool _estElectrique;

        public string Type
        {
            get { return _type; }
        }

        public bool EstElectrique
        {
            get { return _estElectrique; }
            set { _estElectrique = value; }
        }

        public Velo(string type, bool estElectrique, string marque, string modele, string couleur, decimal prix) : base (marque, modele, couleur, prix)
        {
            _type = type;
            _estElectrique = estElectrique;
        }

        public string Affichage()
        {
            string boolElectrique = "";
            if (_estElectrique == true)
            {
                boolElectrique = "fonctionne en électrique";
            } else
            {
                boolElectrique = "ne fonctionne pas en électrique";
            }

            string info = "  [+] Marque: " + _marque + "\n  [+] Modèle: " + _modele + "\n  [+] Couleur: " + _couleur + "\n  [+] Prix: " + _prix + "\n  [+] Type: " + _type + "\n  [+] Le vehicule " + boolElectrique;
            return info;
        }
    }

}
