﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Animal
    {
        #region Atributos
        private int _edad;
        #endregion

        #region Propiedad
        public int Edad
        {
            get { return this._edad; }
            set { this._edad = value; }
        }
        #endregion

        #region Constructor
        public Animal(int edad)
        {
            this._edad = edad;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return " "+this._edad+" ";
        }
        #endregion
    }
}
