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

		public override int CalculerSurface()
		{
			int surface = CotePrincipale * CoteSecondaire;
			return surface;
		}

		public override int CalculerPerimetre()
		{
			int perimetre = (CotePrincipale * 2) + (CoteSecondaire * 2);
			return perimetre;
		}
    }
}
