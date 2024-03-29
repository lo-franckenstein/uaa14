﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Act7_CourseChien.POO
{
    class Parieur
    {

        protected string _nom;
        protected Pari _monPari;
        protected int _cash;
        protected TextBlock _textBlockEtatPari;

        public string Nom
        {
            get { return _nom; }
        }

        public Pari MonPari
        {
            get { return _monPari; }
            set { _monPari = value; }
        }

        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }

        public TextBlock TextBlockEtatPari
        {
            get { return _textBlockEtatPari; }
            set { _textBlockEtatPari = value; }
        }

        public Parieur (string nom, Pari monPari, int cash, TextBlock textBlockEtatPari)
        {
            _nom = nom;
            _monPari = monPari;
            _cash = cash;
            _textBlockEtatPari = textBlockEtatPari;
        }


    }
}
