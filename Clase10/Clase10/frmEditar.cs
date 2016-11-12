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
    public partial class frmEditar : Form
    {
        private Persona _persona;

        public Persona Persona
        {
            get { return _persona; }
            //set { _persona = value; }
        }

        public frmEditar()
        {
            InitializeComponent();
            
        }

        public frmEditar(Persona unaPersona):this()
        {
            this.txtNombre.Text = unaPersona.Nombre;
            this.txtApellido.Text = unaPersona.Apellido;
            this.txtEdad.Text = unaPersona.Edad.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._persona = new Persona(this.txtNombre.Text,this.txtApellido.Text, int.Parse(this.txtEdad.Text));

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void frmEditar_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
