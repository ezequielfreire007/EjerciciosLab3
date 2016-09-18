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
    public partial class frmAuto : frmVehiculo
    {
        private Auto _auto;

        public Auto Auto
        {
            get { return this._auto; }
        }

        public frmAuto()
        {
            InitializeComponent();
            
        }

        //Sobrescritura de manejador de evneto de boton Aceptar
        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto unAuto = new Auto(txtPatente.Text, txtMarca.Text, (EColores)cmbColor.SelectedItem, int.Parse(txtCantidadPuertas.Text));
            this._auto = unAuto;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        //Sobrescritura de manejador de evneto de boton Aceptar
        public override void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Dispose();
        }


    }
}
