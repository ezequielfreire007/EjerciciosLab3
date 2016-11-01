using System;
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

        #region Propiedades
        public int Edad
        {
            get { return this._edad; }
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
            return "Edad: " + this._edad;
        }
        #endregion
    }
}
