using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int monto = int.Parse(textMonto.Text);
            if ((monto >= 30) && (monto <= 50) )
            {
                double des = monto * 0.1;
                textDescuento.Text = (des).ToString();
                textTotal.Text = (monto - des).ToString();
                textDescuento.Enabled = false;
                textTotal.Enabled = false;
            }
            else if (monto > 50)
            {
                double des = monto * 0.2;
                textDescuento.Text = (des).ToString();
                textTotal.Text = (monto - des).ToString();
                textDescuento.Enabled = false;
                textTotal.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textMonto.Text = "";
            textDescuento.Text = "";
            textTotal.Text = "";
            textDescuento.Enabled = true;
            textTotal.Enabled = true;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
