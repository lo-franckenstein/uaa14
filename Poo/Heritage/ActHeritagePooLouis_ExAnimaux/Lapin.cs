using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_ExAnimaux
{
    class Lapin : Animal
    {
        protected int _tailleOreille;

        public int tailleOreille
        {
            get { return _tailleOreille; }
            set { _tailleOreille = value; }
        }


        public Lapin( int tailleOreille, string nom, DateTime dateNaissance, int numeroPuce, int Taille, bool animalConcours) : base(nom, dateNaissance, numeroPuce, Taille, animalConcours) 
        {
            _tailleOreille = tailleOreille;
        }

        public override string AffichageCaractéristiques()
        {
            string Concours = "";
            if (_animalConcours == true)
            {
                Concours = "Il n'est pour l'instant pas fait pour les concours";
            }
            else
            {
                Concours = "Il est fait pour l'instant pour les concours";
            }
            string info = "Nom: " + _nom + "\n  [+] Date de naissance: " + _dateNaissance + "\n  [+] Numéro de puce: " + _numeroPuce + "\n  [+] Taille: " + _taille + "cm\n  [+] Concours:" + Concours;
            return info;
        }

        public string Sauter()
        {
            string stringSauter = _nom + " est en train de bondir";
            return stringSauter;
        }
    }
}
