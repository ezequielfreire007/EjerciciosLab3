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

namespace Aplicacion._09
{
    public partial class frmGestionAutomovil : Form
    {
        private List<Vehiculo> _listaVehiculos;

        public List<Vehiculo> ListaVehiculos
        {
            get { return this._listaVehiculos; }
        }

        public frmGestionAutomovil()
        {
            InitializeComponent();
            this._listaVehiculos = new List<Vehiculo>();
        }

        private void salidAdmDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmGestionAutomovil_Load(object sender, EventArgs e)
        {
            
        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuto formAuto = new frmAuto();
            formAuto.ShowDialog();

            if (formAuto.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this._listaVehiculos.Add(formAuto.Auto);
                this.lstVehiculos.Items.Clear();
                foreach (var item in this._listaVehiculos)
                {
                    this.lstVehiculos.Items.Add(item);
                }
            }
  
        }

    }
}
