using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActHeritagePooLouis_ExAnimaux
{
    class Chat : Animal
    {

        public Chat(string nom, DateTime dateNaissance, int numeroPuce, int Taille, bool animalConcours) : base(nom, dateNaissance, numeroPuce, Taille, animalConcours) { }

        public string miauler()
        {
            string stringMiauler = _nom + " est en train de miauler";
            return stringMiauler;
        }

        public string ronronner()
        {
            string stringRonronner = _nom + " est en train de ronronner";
            return stringRonronner;
        }
    }
}
