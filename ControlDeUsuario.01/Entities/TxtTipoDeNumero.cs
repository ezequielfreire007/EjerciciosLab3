using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public enum ETipoDato
    {
        Entero,
        Double,
        Binario,
        Octal,
        Hexadecimal
    }

    public class TxtTipoDeNumero : TextBox
    {
        public ETipoDato tipo { get; set; }
        public Array _listaChar;

        public TxtTipoDeNumero()
        {
            this.tipo = ETipoDato.Entero;
            this._listaChar = null;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            Array miArrayPorTipo = CambiarTipo(e.KeyChar);
            foreach (Char item in miArrayPorTipo)
            {
                if ((e.KeyChar != item) && (e.KeyChar != (Char)Keys.Back))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                    break;
                }
            }
            base.OnKeyPress(e);
        }

        public Array CambiarTipo(Char letra)
        {
            
            switch (this.tipo)
            {
                case ETipoDato.Entero:
                    Char[] tecla = new Char[] { '0','1','2','3','4','5','6','7','8','9'};
                    this._listaChar = tecla.ToArray();
                    return this._listaChar;          
                case ETipoDato.Double:
                    Char[] teclaDouble = new Char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',','};
                    this._listaChar = teclaDouble.ToArray();
                    return this._listaChar;
                case ETipoDato.Binario:
                    Char[] teclaBinario = new Char[] { '0', '1'};
                    this._listaChar = teclaBinario.ToArray();
                    return this._listaChar;
                case ETipoDato.Octal:
                    Char[] teclaOctal = new Char[] { '0','1','2','3','4','5','6','7'};
                    this._listaChar = teclaOctal.ToArray();
                    return this._listaChar; 
                case ETipoDato.Hexadecimal:
                    Char[] teclaHexa = new Char[] { '0','1','2','3','4','5','6','7','8','9',
                                                'A','B','C','D','E','F'};
                    this._listaChar = teclaHexa.ToArray();
                    return this._listaChar;  
                default:
                    return this._listaChar;
                    
            }
        }

    }
}
