using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_ExAnimaux
{
    class Animal
    {
        protected string _nom;
        protected DateTime _dateNaissance;
        protected int _numeroPuce;
        protected int _taille;
        protected bool _animalConcours;

        public string Nom
        {
            get { return _nom; }
        }

        public DateTime DateNaissance
        {
            get { return _dateNaissance; }
        }

        public int NumeroPuce
        {
            get { return _numeroPuce; }
        }

        public int Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }

        public bool AnimalConcours
        {
            get { return _animalConcours;}
            set { _animalConcours = value;}
        }

        public Animal(string nom, DateTime dateNaissance, int numeroPuce, int taille, bool animalConcours)
        {
            _nom = nom;
            _dateNaissance = dateNaissance;
            _numeroPuce = numeroPuce;
            _taille = taille;
            _animalConcours = animalConcours;
        }

        public virtual string AffichageCaractéristiques ()
        {
            string Concours = "";
            if(_animalConcours == true)
            {
                Concours = "Il n'est pour l'instant pas fait pour les concours";
            } else
            {
                Concours = "Il est fait pour l'instant pour les concours";
            }
            string info = "Nom: " + _nom + "\n  [+] Date de naissance: " + _dateNaissance + "\n  [+] Numéro de puce: " + _numeroPuce + "\n  [+] Taille: " + _taille + "cm\n  [+] Concours:" + Concours;
            return info;
        }
    }
}
