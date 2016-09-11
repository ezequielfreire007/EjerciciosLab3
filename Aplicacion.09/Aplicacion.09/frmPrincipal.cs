using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._09
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Coloca imagen de fonde desde la propiedad
            this.BackgroundImage = Properties.Resources.fondo;
            //Estrecha la imagen al tamaño de la ventana
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //Establesco el icono de la aplicacion
            this.Icon = Properties.Resources.icono_utn;       
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }


    }
}
