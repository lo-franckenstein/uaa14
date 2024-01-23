using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_ExForme
{
    class Forme
    {

        protected string _couleur;
        protected int _cotePrincipale;

        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public int CotePrincipale
        {
            get { return _cotePrincipale;}
            set { _cotePrincipale = value;}
        }

        public Forme(string couleur, int cotePrincipale)
        {
            _couleur = couleur;
            _cotePrincipale = cotePrincipale;    
        }

        public virtual string AfficherCaracteristiques()
        {
            string info = "  [+] Couleur de la forme: " + _couleur + "\n  [+] Mesure du côté principale: " + _cotePrincipale;
            return info;
        }




    }
}
