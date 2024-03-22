using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2BisPOO_Conception
{
    class Bouteille
    {

        private Liquide _contenu;
        private double _contenance;

        public Liquide Contenu
        {
            get { return _contenu; }
        }

        public double Contenance
        {
            get { return _contenance; }
        }

        public Bouteille(Liquide contenu, double contenance)
        {
            _contenu = contenu;
            _contenance = contenance;
        }
    }
}
