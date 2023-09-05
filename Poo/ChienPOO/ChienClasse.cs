using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienPOO
{
    class ChienClasse
    {

        // Attributs privés par convention, leurs noms commence par "_"
        private string _nom;
        private string _race;
        private uint _age;
        private bool _enOrdreDeVaccin;
        private bool _puce;
        private string _genre;
        private bool _sterelise;
        private bool _sourd;
        private bool _aggressif;
        private bool _aveugle;
        private bool _manqueDeMembre;
        private bool _dresse;

        // Méthode publiques

        // Le constructeur (Toujours le même nom que la classe)

        public ChienClasse (string nom, string race, uint age, bool enOrdreDeVaccin, bool puce, string genre, bool sterelise, bool sourd, bool aggressif, bool aveugle, bool manqueDeMembre, bool dresse)
        {
            _nom = nom;
            _race = race;
            _age = age;
            _enOrdreDeVaccin = enOrdreDeVaccin;
            _puce = puce;
            _genre = genre;
            _sterelise = sterelise;
            _sourd = sourd;
            _aggressif = aggressif;
            _aveugle = aveugle;
            _manqueDeMembre = manqueDeMembre;
            _dresse = dresse;

        }

        // Une méthode pour formater les attributs d'un chien dans un string

        public string AfficheCaracteristiques()
        {
            string chaîne =  " [+] Nom: " + _nom + "\n [+] Age: " + _age + "\n [+] Race: " + _race + "\n [+] En ordre de vaccin: " + _enOrdreDeVaccin + "\n [+] Puce: " + _puce + "\n [+] Genre: " + _genre + "\n [+] Stérélisé: " + _sterelise + "\n [+] Sourd: " + _sourd + "\n [+] Aggressif: " + _aggressif + "\n [+] Aveugle: " + _aveugle + "\n [+] Manque de membre: " + _manqueDeMembre + "\n [+] Dressé: " + _dresse;
            return chaîne;
        }

    }
}
