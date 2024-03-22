using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act2BisPOO_Conception
{
    class Cocktail
    {


        private string _nom;
        private double _contenance;
        private Recette _recetteCocktail;

        public string Nom
        {
            get { return _nom; }
        }

        public double Contenance
        {
            get { return _contenance; }
            set { _contenance = value; }
        }


        public Recette RecetteCocktail
        {
            get { return _recetteCocktail;}
        }


        public Cocktail (string nom, double contenance, Recette recetteCocktail)
        {
            _nom = nom;
            _contenance = contenance;
            _recetteCocktail = recetteCocktail;
        }

    }
}
