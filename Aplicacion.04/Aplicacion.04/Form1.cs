using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.lstNumero.Items.Add(txtNumero.Text);
            this.txtNumero.Text = "";
            this.txtNumero.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rdbDescendente.Checked == true)
            {
                this.lstNumero.Sorted = true;
            }

            if (rdbAscendente.Checked == true)
            {
                
                String[] lista = this.lstNumero.Items.Cast<string>().ToArray();
                Array.Sort(lista);
                Array.Reverse(lista);
                this.lstNumero.Items.Clear();

                foreach (string item in lista)
                {
                    this.lstNumero.Items.Add(item);
                }
               
            }
        }    
    }
}
