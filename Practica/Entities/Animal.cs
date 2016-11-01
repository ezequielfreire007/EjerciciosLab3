using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Animal
    {
        private int _edad;

        public int Edad
        {
            get { return this._edad; }
        }

        public Animal(int edad)
        {
            this._edad = edad;
        }

        public override string ToString()
        {
            return this._edad.ToString();
        }
    }
}
