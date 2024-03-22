using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2BisPOO_Conception
{
    class Portion
    {

        private Liquide _contenu;
        private double _quantite;

        public Liquide Contenu
        {
            get { return _contenu; }
        }

        public double Quantite
        {
            get { return _quantite; }
        }

        public Portion(Liquide contenu, double quantite)
        {
            _contenu = contenu;
            _quantite = quantite;
        }

    }
}
