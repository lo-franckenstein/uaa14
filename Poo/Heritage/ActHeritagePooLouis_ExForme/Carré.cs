using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_ExForme
{
    class Carré : Forme
    {
        public Carré(string couleur, int cotePrincipale) : base(couleur, cotePrincipale) {}

        public override int CalculerSurface()
        {
            int surface = CotePrincipale ^ 2;
            return surface;
        }

        public override int CalculerPerimetre()
        {
            int perimetre = CotePrincipale * 4;
            return perimetre;
        }
    }
}
