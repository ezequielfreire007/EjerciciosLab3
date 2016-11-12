using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private Int32 _edad;  

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public Int32 Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public Persona(string nombre, string apellido, Int32 edad)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
        }
    }
}
