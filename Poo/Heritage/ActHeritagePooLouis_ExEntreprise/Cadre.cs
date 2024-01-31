using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_ExEntreprise
{
    class Cadre : Employe
    {

        protected int _indice;

		public int Indice
		{
			get { return _indice; }
			set { _indice = value; }
		}

        public Cadre(int matricule, string nom, string prenom, DateTime dateNaissance, int salaire, int indice) : base(matricule, nom, prenom, dateNaissance, salaire)
        {
            _indice = indice;
        }

        public override int CalculSalaire()
        {
            switch (_indice)
            {
                case 1:
                    _salaire = 13000;
                    break;
                case 2:
                    _salaire = 15000;
                    break;
                case 3:
                    _salaire = 17000;
                    break;
                case 4:
                    _salaire = 20000;
                    break;
                default:
                    _salaire = 0;
                    break;
            }
            return _salaire;
        }

        public override string AfficherCaracteristiques()
        {
            string info = "   Carte de cadre de " + _prenom + " " + _nom + "\n      [Matricule] " + _matricule + "\n      [Nom] " + _nom + "\n      [Prénom] " + _prenom + "\n      [Date de Naissance] " + _dateNaissance + "\n      [Salaire] " + _salaire + "euros\n      [Indice de salaire] " + _indice;
            return info;
        }

    }
}
