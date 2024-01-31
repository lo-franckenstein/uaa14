using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_ExEntreprise
{
    abstract class Employe
    {
        protected int _matricule;
        protected string _nom;
        protected string _prenom;
        protected DateTime _dateNaissance;
        protected int _salaire;

        public int Matricule
        {
            get { return _matricule; }
        }

        public string Nom
        {
            get { return _nom; }
        }

        public string Prenom
        {
            get { return _prenom; }
        }

        public DateTime DateNaissance
        {
            get { return _dateNaissance; }
        }

        public int Salaire
        {
            get { return _salaire; }
        }

        public Employe (int matricule, string nom, string prenom, DateTime dateNaissance, int salaire)
        {
            _matricule = matricule;
            _nom = nom;
            _prenom = prenom;
            _dateNaissance = dateNaissance;
            _salaire = salaire;
        }

        public virtual string AfficherCaracteristiques()
        {
            string info = "   Carte d'employé de " + _prenom + " " + _nom + "\n      [Nom] " + _nom + "\n      [Prénom] " + _prenom + "\n      [Date de Naissance] " + _dateNaissance + "\n      [Salaire] " + _salaire;
            return info;
        }

        public abstract int CalculSalaire();
    }
}
