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


namespace PracticaParcial
{

    public partial class frmPrincipal : Form
    {
        private List<Mascota> _listaMascota;

        public List<Mascota> ListaMascotas
        {
            get { return this._listaMascota; }
        }

        public frmPrincipal()
        {
            InitializeComponent();
            this._listaMascota = new List<Mascota>();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.menuCboOrdenar.ComboBox.DataSource = Enum.GetValues(typeof(eTipoDeOrdenamiento));
            this.menuCboOrdenar.ComboBox.SelectedIndex = 0;
        }

        private void menuAlta_Click(object sender, EventArgs e)
        {
            try
            {
                frmMascota formMascota = new frmMascota();
                formMascota.ShowDialog();

                if (formMascota.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    this._listaMascota.Add(formMascota.Mascota);
                    this.CompletarListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CompletarListBox()
        {
            this.lstMacotas.Items.Clear();
           
            foreach (var item in this._listaMascota)
            {
                this.lstMacotas.Items.Add(item);
            }
            
        }

        private void lstMacotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.menuBaja.Click += new EventHandler(ManejadorCentral);
            this.menuModificar.Click += new EventHandler(ManejadorCentral);
            MessageBox.Show(this.lstMacotas.SelectedIndex.ToString());
        }

        private void ManejadorCentral(object menu, EventArgs evento)
        {
            ToolStripMenuItem auxmenu = (ToolStripMenuItem)menu;

            if(auxmenu == this.menuBaja)
            {
                if (this.lstMacotas.SelectedIndex != -1)
                {
                    frmMascota formascota = new frmMascota(this._listaMascota[this.lstMacotas.SelectedIndex]);
                    formascota.ShowDialog();
                    if (formascota.DialogResult == System.Windows.Forms.DialogResult.OK)
                    {
                        this._listaMascota.RemoveAt(this.lstMacotas.SelectedIndex);
                        this.CompletarListBox();
                    }  
                }

                //Saco el manejador del evento click de baja y modificar
                this.menuBaja.Click -= new EventHandler(ManejadorCentral);
                this.menuModificar.Click -= new EventHandler(ManejadorCentral);
            }

            if (auxmenu == this.menuModificar)
            {
                foreach (Mascota item in this._listaMascota)
                {
                    if (item.Equals(this._listaMascota[this.lstMacotas.SelectedIndex]))
                    {
                        frmMascota formascota = new frmMascota(item);
                        formascota.ShowDialog();

                        if (formascota.DialogResult == System.Windows.Forms.DialogResult.OK)
                        {
                            this._listaMascota[this.lstMacotas.SelectedIndex] = formascota.Mascota;
                            this.CompletarListBox();
                        }
                        break;
                    }
                }
                //Saco el manejador del evento click de baja y modificar
                this.menuBaja.Click -= new EventHandler(ManejadorCentral);
                this.menuModificar.Click -= new EventHandler(ManejadorCentral);
            }
        }

        private void menuCboOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox auxCombo = (ToolStripComboBox)sender;
            if ((eTipoDeOrdenamiento)auxCombo.SelectedIndex == eTipoDeOrdenamiento.PorEdad)
            {
                this._listaMascota.Sort(Mascota.OrdenarPorEdad);
            }

            if ((eTipoDeOrdenamiento)auxCombo.SelectedIndex == eTipoDeOrdenamiento.PorNombre)
            {
                this._listaMascota.Sort(Mascota.OrdenarPorNombre);
            }

            if ((eTipoDeOrdenamiento)auxCombo.SelectedIndex == eTipoDeOrdenamiento.PorTipo)
            {
                this._listaMascota.Sort(Mascota.OrdenarPorTipo);
            }
            
            
            this.CompletarListBox();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de salir?", "Salir?",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter("Leer.txt",true))
                {
                    foreach (Mascota item in this._listaMascota)
                    {
                        archivo.WriteLine(item.ToString());
                    }
                }
            }
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
