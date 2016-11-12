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
using System.IO;

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
                this._listaMascotas.Add(formMascota.UnaMascota);
                this.MostrarListbox();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //DropDonwStyle para que no se pueda ingresar datos o modificarlos en el combobox
            this.toolStripCmbOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
            //DataSourse toma los valores desde desde getvalues del enumerado
            this.toolStripCmbOrdenar.ComboBox.DataSource = Enum.GetValues(typeof(eTipoDeOrdenamiento));
            this.toolStripCmbOrdenar.SelectedIndex = 0;
        }

        private void manejadorCentral(object sender, EventArgs e)
        {
            MessageBox.Show("Mi manejador");
            ToolStripMenuItem menuAux = (ToolStripMenuItem)sender;

            if (menuAux == this.bajaToolStripMenuItem)
            {
                MessageBox.Show("Menu Baja");
                Mascota miMascota = this._listaMascotas[this.lstMascotas.SelectedIndex];

                frmMascota fromMascota = new frmMascota(miMascota);
                fromMascota.ShowDialog();

                if (fromMascota.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    this._listaMascotas.Remove(miMascota);
                }
                else
                {
                    MessageBox.Show("Se cancela la eliminacion de la mascota");
                }

                this.MostrarListbox();

                //Saco los manejadores de los eventos
                this.bajaToolStripMenuItem.Click -= new EventHandler(manejadorCentral);
                this.modificacionToolStripMenuItem.Click -= new EventHandler(manejadorCentral);
            }

            if (menuAux == this.modificacionToolStripMenuItem)
            {
                MessageBox.Show("Menu Modificar");

                frmMascota fromMascota = new frmMascota(this._listaMascotas[this.lstMascotas.SelectedIndex]);
                fromMascota.ShowDialog();

                if (fromMascota.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    this._listaMascotas[this.lstMascotas.SelectedIndex] = fromMascota.UnaMascota;
                }
                else
                {
                    MessageBox.Show("No se efectua la modificacion");
                }

                this.MostrarListbox();

                //Saco los manejadores de los eventos
                this.bajaToolStripMenuItem.Click -= new EventHandler(manejadorCentral);
                this.modificacionToolStripMenuItem.Click -= new EventHandler(manejadorCentral);
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstMascotas.SelectedIndex != -1)
            {
                this.bajaToolStripMenuItem.Click += new EventHandler(manejadorCentral);
                this.modificacionToolStripMenuItem.Click += new EventHandler(manejadorCentral);
                MessageBox.Show("Se agregaron los manejadores de envento de alta y modificar");
            }
            else
            {
                MessageBox.Show("El valores -1");
            }
        }

        //ORDENAMIENTO DE DATOS SEGUN EL ENUMERADO
        private void toolStripCmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Segun el tipo seleccionado Ordeno la lista

            ToolStripComboBox combo = (ToolStripComboBox)sender;
            //Comparison<Mascota> comparador;
            switch ((eTipoDeOrdenamiento)combo.SelectedIndex)
            {
                case eTipoDeOrdenamiento.PorEdad:
                    Comparison<Mascota> comparador = new Comparison<Mascota>(Mascota.OrdenarPorEdad);
                    this._listaMascotas.Sort(comparador);
                    this.MostrarListbox();  
                    break;
                case eTipoDeOrdenamiento.PorNombre:
                    comparador = new Comparison<Mascota>(Mascota.OrdenarPorNombre);
                    this._listaMascotas.Sort(comparador);
                    this.MostrarListbox();
                    break;
                case eTipoDeOrdenamiento.PorTipo:
                    comparador = new Comparison<Mascota>(Mascota.OrdenarPorTipo);
                    this._listaMascotas.Sort(comparador);
                    this.MostrarListbox();
                    break;
                default:
                    break;
            }

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la aplicacion?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Information) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                using (StreamWriter escritor = new StreamWriter("Lista.txt", true))
                {
                    foreach (Mascota mascota in this._listaMascotas)
                    {
                        escritor.WriteLine(mascota.ToString());
                    }
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
