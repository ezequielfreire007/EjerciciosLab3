using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textNumero.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = 0;
            num = int.Parse(this.textNumero.Text);
            string dato = "";

            for (int i = 1; i <= 10; i++)
            {
                dato = num + " * " + i + " = " + num * i;
                this.lstTabla.Items.Add(dato);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textNumero.Text = "";
            this.lstTabla.Items.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Ësta seguro que desea salir?","Atencion al cierre",MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Continua en la aplicacion.");
            }
        }
    }
}
