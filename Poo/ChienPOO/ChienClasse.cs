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

        public uint Age        {
            get { return _age; }
            set { _age = value; }
        }

        public bool Vaccin
        {
            get { return _enOrdreDeVaccin; }
            set { _enOrdreDeVaccin = value; }
        }

        public bool Puce
        {
            get { return _puce; }
            set { _puce = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public bool Sterilise
        {
            get { return _sterelise; }
            set { _sterelise = value; }
        }

        public bool Sourd
        {
            get { return _sourd; }
            set { _sourd = value; }
        }

        public bool Aggressif
        {
            get { return _aggressif; }
            set { _aggressif = value; }
        }

        public bool Aveugle
        {
            get { return _aveugle; }
            set { _aveugle = value; }
        }
        public bool ManqueDeMembres
        {
            get { return _manqueDeMembre; }
            set { _manqueDeMembre = value; }
        }
        public bool Dresse
        {
            get { return _dresse; }
            set { _dresse = value; }
        }





    }
}
