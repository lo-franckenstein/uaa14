using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_ExForme
{
    class Carré : Forme
    {
        public Carré(string couleur, int cotePrincipale) :base(couleur, cotePrincipale);

        public int CalculerSurface(int cotePrincipale)
        {
            int surface = cotePrincipale ^ 2;
            return surface;
        }

        public int CalculerPerimetre(int cotePrincipale)
        {
            int perimetre = cotePrincipale * 4;
            return perimetre;
        }
    }
}
