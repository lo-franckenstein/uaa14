using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace I2P623_FranckenLouis
{
    class FeuFonctionnement
    {

        public int _couleur;
        public string _identifiant;
        public int _frequence;

        bool eteint;
        bool frequence;

        public Declaration(int couleur, string identifiant, int frequence)
        {
            couleur = _couleur;
            identifiant = _identifiant;
            frequence = _frequence;
        }


        public int Change
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public int Clignote
        {
            get { return _frequence; }
            set { _frequence = value; }
        }




        public string AffichageCligno()
        {
            string affichage2 = "";
            for (int i = 0; i < _frequence + 1; i++)
            {
                affichage2 += "007 est éteint \n 007 est allumé";
            }
            return affichage2;
        }


        public string AfficheEtat()
        {
            string coucouleur;
            if (_couleur == 1)
            {
                coucouleur = "rouge";
            } else if(_couleur == 2)
            {
                coucouleur = "orange";
            } else
            {
                coucouleur = "vert";
            }

            string affichage = "Le feu de signalisation " + _identifiant + " est " + coucouleur;
            return affichage;
        }




        
                     

    }
}
