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

namespace Modelo2doParcialLab3
{
   
    public partial class frmAlumno : Form
    {
        private Alumno _unAlumno;

        public Alumno UnAlumno
        {
            get { return this._unAlumno; }
        }

        public frmAlumno(DataTable tabla)
        {
            InitializeComponent();
            
            
            //Se inserta los datos de la tabla al comboBox
            this.cmbCurso.DataSource = tabla;
            //Se setea el estilo para que el usuario no modifique el combo
            this.cmbCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            //Establesco la clave
            this.cmbCurso.ValueMember = "Codigo";
            //Establesco el valor
            this.cmbCurso.DisplayMember = "Nombre";
            this.cmbCurso.SelectedIndex = 0;
            
        }

        public frmAlumno(Alumno alumno, DataTable tabla):this(tabla)
        {
            this.txtApellido.Text = alumno.Apellido;
            this.txtLegajo.Text = alumno.Legajo.ToString();
            this.cmbCurso.SelectedItem = alumno.Curso;

            if (alumno.Curso == 1000)
            {
                this.cmbCurso.SelectedIndex = 0;
            }

            if (alumno.Curso == 1005 )
            {
                this.cmbCurso.SelectedIndex = 1;
            }

            if (alumno.Curso == 1010)
            {
                this.cmbCurso.SelectedIndex = 2;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this._unAlumno == null)
            {
                this._unAlumno = new Alumno(this.txtApellido.Text, int.Parse(this.cmbCurso.SelectedValue.ToString()), int.Parse(txtLegajo.Text));    
            }
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
           // this.cmbCurso.DataSource = Enum.GetValues(typeof(ECurso));
            //this.cmbCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            //this.cmbCurso.SelectedIndex = (int)ECurso.CSHARP;
        }


    }
}
