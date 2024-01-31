using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_ExEntreprise
{
    class Directeur : Employe
    {

        protected int _ca;
        protected int _pourcentage;

        public int Ca
        {
            get { return _ca; }
            set { _ca = value; }
        }

        public int Pourcentage
        {
            get { return _pourcentage;}
            set { _pourcentage = value;}
        }

        public Directeur(int matricule, string nom, string prenom, DateTime dateNaissance, int salaire, int ca, int pourcentage) : base(matricule, nom, prenom, dateNaissance, salaire)
        {
            _ca = ca;
            _pourcentage = pourcentage;
        }

        public override int CalculSalaire()
        {
            _salaire = (_ca / 100) * _pourcentage;

            return _salaire;
        }

        public override string AfficherCaracteristiques()
        {
            string info = "   Carte de directeur de " + _prenom + " " + _nom + "\n      [Matricule] " + _matricule + "\n      [Nom] " + _nom + "\n      [Prénom] " + _prenom + "\n      [Date de Naissance] " + _dateNaissance + "\n      [Salaire] " + _salaire + "euros\n      [Pourcentage du CA] " + _pourcentage + "pourcent\n      [Chiffre d'affaire] " + _ca + "euros";
            return info;
        }

    }
}
