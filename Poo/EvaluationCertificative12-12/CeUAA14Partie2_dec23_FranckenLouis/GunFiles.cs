using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeUAA14Partie2_dec23_FranckenLouis
{
    class GunFiles
    {
		public int _ballReserve;
		public int _ballGun;
		public bool _recharge;
		private int _quantiteChargeur;
		private int _quantiteDebut;


		// Constructeur



		

		public int BallReservee
		{
			get { return _ballReserve; }
			set { _ballReserve = value; }
		}

		public int BallDansGun
		{
			get { return _ballGun; }
			set { _ballGun = value; }
		}

        public bool Chargement
        {
            get { return _recharge; }
            set { _recharge = value; }
        }


        public int QuantitéChargeuur
		{
			get { return _quantiteChargeur; }
		}

        public int QuantitéDébut
        {
            get { return _quantiteDebut; }
        }

        public GunFiles(int ballReserve, int ballGun, bool recharge, int quantiteChargeur, int quantiteDebut)
		{
			_ballReserve = ballReserve;
			_ballGun = ballGun;
			_recharge = recharge;
			_quantiteChargeur = quantiteChargeur;
			_quantiteDebut = quantiteDebut;
		}

		public bool Tirer(int _ballGun)
		{
			_ballGun = _ballGun - 1;
			return true;
		}

		public bool Recharger(int _ballGun, int _ballReserve, int _quantiteChargeur)
		{
			if (_quantiteChargeur <= _ballReserve)
			{
				_ballGun = _quantiteChargeur;
				_ballReserve = _ballReserve - _quantiteChargeur;
			} else
			{
				_ballGun = _ballReserve;
				_ballReserve = 0;
			}
			return true;
		}


		public string AffichageStuff(int _ballReserve, int _ballGun, bool _recharge)
		{
			string messageRecharge;
			if (_recharge == true)
			{
				messageRecharge = "Votre arme est rechargée";
			} else
			{
				messageRecharge = "Votre arme n'est pas rechargée";
			}

			if (_ballReserve == 0 && _ballGun == 0) 
			{ 
				return "Vous avez raté votre évaluation, merci de cliquer sur [Q] pour quitter"; 
			} else if (_ballGun == 0)
			{
				return "Vous êtes en train de courrir dans une prairie mais vous n'avez plus de balles dans votre chargeur, n'oubliez pas de le charger\n===================================================\n";
            } else
			{
				return "Vous êtes en train de courrir dans une prairie\n===================================================\n  [+] Balles dans votre chargeur: " + _ballGun + "\n  [+] Balles de réserve: " + _ballReserve + "\n  [+] " + messageRecharge + "\n\n[ESPACE] Tirer\n[R] Recharger\n[Q] Quitter l'évaluation";
			}
        }



	}
}
