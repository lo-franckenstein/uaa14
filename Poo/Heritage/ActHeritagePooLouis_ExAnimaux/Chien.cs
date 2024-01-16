using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_ExAnimaux
{
    class Chien : Animal
    {

        public Chien (string nom, DateTime dateNaissance, int numeroPuce, int Taille, bool animalConcours) : base (nom, dateNaissance, numeroPuce, Taille, animalConcours){}

        public string Aboyer()
        {
            string stringAboyer = _nom + " est en train d'aboyer";
            return stringAboyer;
        }
    }
}
