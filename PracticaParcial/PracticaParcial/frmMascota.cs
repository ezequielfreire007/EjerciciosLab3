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

namespace PracticaParcial
{

    public partial class frmMascota : frmAnimal
    {
        private Mascota _mascota;

        public Mascota Mascota
        {
            get { return this._mascota; }
        }

        public frmMascota()
        {
            InitializeComponent();
            
        }

        public frmMascota(Mascota mascota):this()
        {
            this._mascota = mascota;
        }

        private void frmMascota_Load(object sender, EventArgs e)
        {
            if (this._mascota != null)
            {
                this.cmbTipoMascotas.DropDownStyle = ComboBoxStyle.DropDownList;   
                this.cmbTipoMascotas.DataSource = Enum.GetValues(typeof(eTipoDeMascota));
                this.txtNombre.Text = this._mascota.Nombre;
                this.txtEdad.Text = this._mascota.Edad.ToString();
                this.cmbTipoMascotas.SelectedIndex = (int)this._mascota.TipoDeMascota;
            }
            else
            {
                //El DropDownStyle solo permite elegir algun elemento del combo box
                this.cmbTipoMascotas.DropDownStyle = ComboBoxStyle.DropDownList;
                //Completo el combo con el enumerado
                this.cmbTipoMascotas.DataSource = Enum.GetValues(typeof(eTipoDeMascota));
                this.cmbTipoMascotas.SelectedIndex = 0;
            }
            
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            this._mascota = new Mascota(txtNombre.Text, (eTipoDeMascota)cmbTipoMascotas.SelectedIndex, int.Parse(txtEdad.Text));
            base.btnAceptar_Click(sender, e);
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }
        
    }
}
