using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class TxtSoloNumeros: TextBox
    {
        private  Char [] _listaCaracteres;

        public TxtSoloNumeros()
        {
            this._listaCaracteres = new Char [] {'0','1','2','3','4','5','6','7','8','9'};
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            foreach (Char item in this._listaCaracteres)
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
    }
}
