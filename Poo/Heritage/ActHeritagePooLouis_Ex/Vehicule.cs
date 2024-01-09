using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_Ex
{
    class Vehicule
    {
        protected string _modele;
        protected string _marque;
        protected string _couleur;
        protected decimal _prix;

        public string Modele
        {
            get { return _modele; }
            set { _modele = value; }
        }

        public string Marque
        {
            get { return _marque; }
        }

        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public decimal Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }


        public Vehicule (string modele, string marque, string couleur, decimal prix)
        {
            _modele = modele;
            _marque = marque;
            _couleur = couleur;
            _prix = prix;
        }





    }
}
