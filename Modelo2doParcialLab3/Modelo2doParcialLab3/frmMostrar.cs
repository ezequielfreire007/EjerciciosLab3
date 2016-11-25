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
    public partial class frmMostrar : Form
    {
        public frmMostrar()
        {
            InitializeComponent();
        }

        public frmMostrar(DataSet miDataSet, EMostrar queMuestro):this()
        {
            DataRow fila;
            DataTable dtMostrar = new DataTable("Mostrar");

            switch (queMuestro)
            {
                case EMostrar.Alumnos:
                    this.dataGridView1.DataSource = miDataSet;
                    this.dataGridView1.DataMember = "Alumnos";
                    break;
                case EMostrar.Cursos:
                    break;
                case EMostrar.AlumnosConNombre:
                    break;
                case EMostrar.AlumnosDePHP:
                    break;
                default:
                    break;
            }
        }
    }
}
