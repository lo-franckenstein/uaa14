using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_ExForme
{
    class Rectangle : Forme
    {
        protected int _coteSecondaire;

		public int CoteSecondaire
		{
			get { return _coteSecondaire; }
			set { _coteSecondaire = value; }
		}

		public Rectangle(string couleur, int cotePrincipale, int coteSecondaire):base(couleur, cotePrincipale)
		{
			_coteSecondaire = coteSecondaire;
		}

        public override string AfficherCaracteristiques()
        {
			string info = "  [+] Couleur de la forme: " + _couleur + "\n  [+] Mesure du côté principale: " + _cotePrincipale + "\n  [+] Mesure du côté secondaire: " + _coteSecondaire;
            return info;
        }

		public int CalculSurface(int cotePrincipale, int coteSecondaire)
		{
			int surface = cotePrincipale * coteSecondaire;
			return surface;
		}

		public int CalculPerimetre(int cotePrincipale, int coteSecondaire)
		{
			int perimetre = (cotePrincipale * 2) + (coteSecondaire * 2);
			return perimetre;
		}
    }
}
