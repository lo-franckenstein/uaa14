using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act7_CourseChien.POO
{
    class Pari
    {

        protected int _montant;
        protected int _numChien;
        protected Parieur _joueur;

        public int Montant
        {       
            get { return _montant; }
            set { _montant = value; }
        }

        public int NumChien {
            get { return _numChien; } 
            set { _numChien = value; } 
        }

        public Parieur Joueur
        {
            get { return _joueur; }
            set { _joueur = value; }
        }

    }
}
