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
        SoloLetras
    }

    public class TexboxSelect : TextBox
    {
        #region Atributos
        public TipoDeDato tipo { get; set; }
        
        #endregion

        #region Constructor
        public TexboxSelect()
        {
            this.tipo = TipoDeDato.Ninguno;

        }
        #endregion

        #region Metodos
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (this.tipo)
            {
                case TipoDeDato.Ninguno:
                    break;
                case TipoDeDato.SoloNumeros:
                    Char [] caracterNum = new Char [] {'0','1','2','3','4','5','6','7','8','9'};
                    foreach (Char item in caracterNum)
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
                case TipoDeDato.SoloLetras:
                    Char[] caracter = new Char[] {'a','b','c','d','e','f','g','h','i','j','k','l',
                                       'm','n','ñ','o','p','q','r','s','t','w','x','y','z'};
                    foreach (Char item in caracter)
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

        #endregion

    }
}
