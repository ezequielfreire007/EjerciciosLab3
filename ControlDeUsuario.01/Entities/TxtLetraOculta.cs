using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class TxtLetraOculta : TextBox
    {
        public Char letraOculta {get; set;}

        public TxtLetraOculta()
        {
            this.letraOculta = 'E';
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == this.letraOculta)
            {
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }
    }
}
