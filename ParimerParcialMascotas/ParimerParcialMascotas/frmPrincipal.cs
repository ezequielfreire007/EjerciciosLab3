using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace ParimerParcialMascotas
{
    public partial class frmPrincipal : Form
    {
        //Atributos
        private List<Mascota> _listaMascotas;

        //Propiedades
        public List<Mascota> ListaMascotas
        {
            get { return this._listaMascotas; }
        }

        //Constructor
        public frmPrincipal()
        {
            InitializeComponent();
            this._listaMascotas = new List<Mascota>();
        }

        public void MostrarListbox()
        {
            this.lstMascotas.Items.Clear();

            foreach (Mascota item in this._listaMascotas)
            {
                this.lstMascotas.Items.Add(item.ToString());
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMascota formMascota = new frmMascota();
            formMascota.ShowDialog();

            if (formMascota.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //MessageBox.Show("mensaje ok", "mensaje", MessageBoxButtons.OK);
                this._listaMascotas.Add(formMascota.UnaMascota);
                this.MostrarListbox();
            }
        }
    }
}
