using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion._05
{
    public class Numero
    {
        private int _numero;

        public int UnNumero
        {
            get { return this._numero; }
        }

        public Numero(int numero)
        {
            this._numero = numero;
        }

        public int CantidadCifras()
        {
            int retorno = 0;
            char[] cantidad = this._numero.ToString().ToArray();

            retorno = cantidad.Count();

            return retorno;

        }


        public int SumaImpares()
        {
            int retorno = 0;

            char [] cantidad = this._numero.ToString().ToArray();

            foreach (char dato in cantidad)
            {
                if (!(int.Parse(dato.ToString()) % 2 == 0))
                {
                    retorno += int.Parse(dato.ToString());
                }
            }

            return retorno;
        }

        public int SumaPares()
        {
            int retorno = 0;

            char[] cantidad = this._numero.ToString().ToArray();

            foreach (char dato in cantidad)
            {
                if( int.Parse(dato.ToString()) % 2 == 0)
                {
                    retorno += int.Parse(dato.ToString());
                }
            }

            return retorno;
        }

        public int SumaTotal()
        {
            int retorno = 0;

            char[] cantidad = this._numero.ToString().ToArray();

            foreach (char dato in cantidad)
            {
                retorno += int.Parse(dato.ToString());
            }

            return retorno;
        }

        public int CifraMayor()
        {
            int retorno = 0;
            char[] cantidad = this._numero.ToString().ToArray();

            //Ordeno el array
            Array.Sort(cantidad);

            //invierto el array
            Array.Reverse(cantidad);

            //Tomo el primer valor que es el mayor
            retorno = cantidad[1];

            return retorno;
        }

        public int CifraMenor()
        {
            int retorno = 0;
            char[] cantidad = this._numero.ToString().ToArray();

            //Ordeno el array
            Array.Sort(cantidad);

            //Tomo el primer valor que es el menor
            retorno = cantidad[1];
            
            return retorno;
        }
    }
}
