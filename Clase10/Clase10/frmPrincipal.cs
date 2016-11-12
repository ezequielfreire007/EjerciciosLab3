using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase10
{
    public partial class frmPrincipal : Form
    {
        private List<Persona> _listaPersonas;
        private BindingSource miBinding;

        //
        private Binding btnNombre;
        private Binding btnApellido;
        private Binding btnEdad;

        public frmPrincipal()
        {
            InitializeComponent();
            this._listaPersonas = new List<Persona>();
            Persona una = new Persona("Pepe", "Perez", 1);
            Persona dos = new Persona("Mario", "Gonzalez", 2);
            Persona tres = new Persona("Pepe", "Perez", 3);
            Persona cuatro = new Persona("Pepe", "Perez", 4);
            Persona cinco = new Persona("Pepe", "Perez", 5);

            this._listaPersonas.Add(una);
            this._listaPersonas.Add(dos);
            this._listaPersonas.Add(tres);
            this._listaPersonas.Add(cuatro);
            this._listaPersonas.Add(cinco);

            //Encapsula el origen de datos en un formulario
            this.miBinding = new BindingSource();
            this.miBinding.DataSource = this._listaPersonas;
            //Paso el mi BindinSource a la grilla
            this.dataGridPersona.DataSource = this.miBinding;
            
            
        }

        private void dataGridPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridPersona.MultiSelect = false;
            //Permite seleccionar todo las celdas de una fila al hacer click
            this.dataGridPersona.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPersona.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.btnNombre = new Binding("Text", this.miBinding, "Nombre",false,DataSourceUpdateMode.Never);
            this.btnApellido = new Binding("Text", this.miBinding, "Apellido",false, DataSourceUpdateMode.Never);
            this.btnEdad = new Binding("Text", this.miBinding, "Edad",false,DataSourceUpdateMode.Never);

            this.txtNombre.DataBindings.Add(this.btnNombre);
            this.txtApellido.DataBindings.Add(this.btnApellido);
            this.txtEdad.DataBindings.Add(this.btnEdad);
        }

        private void ManejadorBtn(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            switch (boton.Name)
            {
                case "btnPrimero":
                    this.miBinding.MoveFirst();
                    break;
                case "btnSeguiente":
                    this.miBinding.MoveNext();
                    break;
                case "btnAnterior":
                    this.miBinding.MovePrevious();
                    break;
                case "btnUltimo":
                    this.miBinding.MoveLast();
                    break;

            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmEditar alta = new frmEditar();

            if ( alta.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                this.miBinding.Add(alta.Persona);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmEditar alta = new frmEditar((Persona)miBinding.Current);
            if (alta.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.miBinding.Remove((Persona)miBinding.Current);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona p = (Persona)miBinding.Current;
            int index;
            index=miBinding.IndexOf(p);
            frmEditar modificar = new frmEditar(p);
            if (modificar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                this.miBinding[index] = modificar.Persona;


               
                
            }
        }

    
    }
}
