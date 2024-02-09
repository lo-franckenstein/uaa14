using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Act7_CourseChien.POO
{
    public class Chien
    {
        protected int _longueurPiste;
        protected int _numChien;
        protected Image _imageChien;
        protected int[] _positionCourante;
        protected bool _gagne;

        public int LongueurPiste
        {
            get { return _longueurPiste; }
        }

        public int NumChien
        {
            get { return _numChien; }
        }

        public Image ImageChien
        {
            get { return _imageChien; }
        }

        public int[] PositionCourante
        {
            get { return _positionCourante; }
            set { _positionCourante = value; }
        }

        public bool Gagne
        {
            get { return _gagne; }
            set { _gagne = value; }
        }

        public Chien (int longueurPiste, int numChien, Image imageChien, int[] positionCourante, bool gagne)
        {
            _longueurPiste = longueurPiste;
            _numChien = numChien;
            _imageChien = imageChien;
            _positionCourante = positionCourante;
            _gagne = gagne;
        }



    }
}
