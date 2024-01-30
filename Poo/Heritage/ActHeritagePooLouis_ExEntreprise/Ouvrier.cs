using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_ExEntreprise
{
    class Ouvrier : Employe
    {

        protected DateTime _dateEntre;

		public DateTime DateEntre
		{
			get { return _dateEntre; }
		}

		Ouvrier(int matricule, string nom, string prenom, DateTime dateNaissance, int salaire, DateTime dateEntre) : base (matricule, nom, prenom, dateNaissance, salaire)
		{
			dateEntre = _dateEntre;
		}

        public override int CalculSalaire()
        {
            int anneeEntree = _dateEntre.Year;
            int annee = DateTime.Now.Year - anneeEntree;

            if (2500 + (100 * annee) >= 2500 * 2)
            {
                _salaire = 2500 + (100 * annee);
            }
            else
            {
                _salaire = 2500 * 2;
            }

            return _salaire;
        }

        public override string AfficherCaracteristiques()
        {
            string info = "   Carte d'ouvrier de " + _prenom + " " + _nom + "\n      [Nom] " + _nom + "\n      [Prénom] " + _prenom + "\n      [Date de Naissance] " + _dateNaissance + "\n      [Salaire] " + _salaire + "\n      [Date d'arrivée dans notre entreprise] " + _dateEntre;
            return info;
        }

    }
}
