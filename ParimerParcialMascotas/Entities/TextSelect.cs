using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public enum TipoDeDato
    {
        Ninguno,
        SoloNumeros,
        SoloTexto,
    }

    public class TextSelect : TextBox
    {
        //Atributo
        public TipoDeDato tipo { get; set; }

        //Constructor
        public TextSelect()
        {
            this.tipo = TipoDeDato.Ninguno;
        }

        //Metodo OnkeyPress
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (this.tipo)
            {
                case TipoDeDato.Ninguno:
                    break;
                case TipoDeDato.SoloNumeros:
                    Char[] numero = new Char[] { '1','2','3','4','5','6','7','8','9','0' };

                    foreach (Char item in numero)
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
                    break;
                case TipoDeDato.SoloTexto:
                    Char[] texto = new Char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','ñ',
                                                'o','p','q','r','s','t','w','x','y','z'};
                    foreach (Char item in texto)
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
                    break;
                default:
                    break;
            }
            base.OnKeyPress(e);
        }
    }
}
