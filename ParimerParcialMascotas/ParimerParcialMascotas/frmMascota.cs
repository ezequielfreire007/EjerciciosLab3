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
    public partial class frmMascota : frmAnimal
    {
        //Atrributos
        private Mascota unaMascota;

        //Propiedades
        public Mascota UnaMascota
        {
            get { return this.unaMascota; }
        }

        //Constructor
        public frmMascota()
        {
            InitializeComponent();
            this.unaMascota = null;
        }

        public frmMascota(Mascota mascota):this()
        {
            this.unaMascota = new Mascota(mascota.Nombre, mascota.TipoDeMascota, mascota.Edad);
            
        }

        //Metodos
        private void frmMascota_Load(object sender, EventArgs e)
        {
            if (this.unaMascota == null)
            {
                //DropDownStyle permite definir caracateristicas del combobox
                this.cmbMascota.DropDownStyle = ComboBoxStyle.DropDownList;//DropDownList no deja modificar los elementos
                //DataSourse permite cargar valores dese un enumerado
                this.cmbMascota.DataSource = Enum.GetValues(typeof(eTipoDeMascota));
                //SelectedIndex permite definir el elemento de la lista que se vera seleccionado
                this.cmbMascota.SelectedIndex = 0;
            }
            else
            {
                this.txtNombre.Text = this.unaMascota.Nombre;
                this.txtEdad.Text = this.unaMascota.Edad.ToString();
                this.cmbMascota.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cmbMascota.DataSource = Enum.GetValues(typeof(eTipoDeMascota));
                this.cmbMascota.SelectedIndex = (int)this.unaMascota.TipoDeMascota;
            }
            
        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            this.unaMascota = new Mascota(txtNombre.Text, (eTipoDeMascota)cmbMascota.SelectedIndex, int.Parse(txtEdad.Text));
            base.btnAceptar_Click(sender, e);
        }

    }
}
