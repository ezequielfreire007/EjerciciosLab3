using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entities;
using Microsoft.VisualBasic;

namespace Modelo2doParcialLab3
{
    public partial class frmPrincipal : Form
    {
        //Atributos
        private DataSet _dataSetAlumnos_Cursos;
        private SqlDataAdapter _dataAdapterAlumnos;
        private SqlCommand _selectAlumnos;
        private SqlCommand _updateAlumnos;
        private SqlCommand _insertAlumnos;
        private SqlCommand _deleteAlumnos;
        private SqlConnection _connection;

        private string PATH_XML_CURSOS = AppDomain.CurrentDomain.BaseDirectory + "DatatableCurso.xml";
        private string PATH_XML_CURSOS_ESQUEMA = AppDomain.CurrentDomain.BaseDirectory + "DatosTablaCursosEsquemas.xml";
       
        //Constructores
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Metodos
        public void CondiguracionDataAdapter()
        {
            try
            {
                //Se establece string de conexion
                this._connection = new SqlConnection(Properties.Settings.Default.stringConexion);
                //Instacia del dataAdapter
                this._dataAdapterAlumnos = new SqlDataAdapter();
                //Comandos 
                this._selectAlumnos = new SqlCommand("select Legajo_Alumno as Legajo, Apellido_Alumno as Apellido, Curso_Alumno as Curso from Alumnos", this._connection);
                this._updateAlumnos = new SqlCommand("update Alumnos set Legajo_Alumno=@Legajo Apellido_Alumno=@Apellido, Curso_Alumno=@Curso where Legajo_Alumno=@Legajo", this._connection);
                this._insertAlumnos = new SqlCommand("insert into Alumnos (Legajo_Alumno,Apellido_Alumno,Curso_Alumno) values (@Legajo,@Apellido,@Curso)", this._connection);
                this._deleteAlumnos = new SqlCommand("delete from Alumnos where Legajo_Alumno=@Legajo", this._connection);
                //Agrego las query al dataAdapter
                this._dataAdapterAlumnos.SelectCommand = this._selectAlumnos;
                this._dataAdapterAlumnos.UpdateCommand = this._updateAlumnos;
                this._dataAdapterAlumnos.InsertCommand = this._insertAlumnos;
                this._dataAdapterAlumnos.DeleteCommand = this._deleteAlumnos;
                //Indico los parametros del comando INSERT
                this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
                this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@Curso", SqlDbType.Int, 5000, "Curso");
                this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@Legajo", SqlDbType.Int, 2000, "Legajo");
                //Indico los parametros del Comando Update
                this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
                this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Curso", SqlDbType.Int,5000, "Curso");
                this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Legajo", SqlDbType.Int, 2000, "Legajo");
                //Indico los parametros del Comando Delete
                this._dataAdapterAlumnos.DeleteCommand.Parameters.Add("@Legajo", SqlDbType.Int, 2000, "Legajo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public DataTable CrearDataTableCurso()
        {
            //Intanciamos un Data Table
            DataTable dtCursos = new DataTable("Cursos");

            //Agregamos las columnas
            dtCursos.Columns.Add(new DataColumn("Codigo", typeof(int)));
            dtCursos.Columns.Add(new DataColumn("Duracion", typeof(int)));
            dtCursos.Columns.Add(new DataColumn("Nombre", typeof(String)));

            //Caracteristicas de Columna ID
            dtCursos.Columns["Codigo"].AutoIncrement = true;
            dtCursos.Columns["Codigo"].AutoIncrementSeed = 1000;
            dtCursos.Columns["Codigo"].AutoIncrementStep = 5;
            
            //Creamos 3 Cursos
            DataRow fila = dtCursos.NewRow();
            fila["Duracion"] = 3;
            fila["Nombre"] = "CSHARP";
            dtCursos.Rows.Add(fila);

            fila = dtCursos.NewRow();
            fila["Duracion"] = 4;
            fila["Nombre"] = "VBNet";
            dtCursos.Rows.Add(fila);

            fila = dtCursos.NewRow();
            fila["Duracion"] = 5;
            fila["Nombre"] = "PHP";
            dtCursos.Rows.Add(fila);

            //Creamos el xml y agregamos los datos
            dtCursos.WriteXmlSchema(PATH_XML_CURSOS_ESQUEMA);
            dtCursos.WriteXml(PATH_XML_CURSOS);

            return dtCursos;
        }

        public void TraerDatos()
        {
            SqlDataReader miDataReader;
            this._selectAlumnos.CommandType = CommandType.Text;

            DataTable dtAlumnos = new DataTable("Alumnos");
            DataTable dtCursos = new DataTable("Cursos");

            try
            {
                this._connection.Open();
                miDataReader = this._selectAlumnos.ExecuteReader();
                dtAlumnos.Load(miDataReader);
                this._connection.Close();
                dtAlumnos.PrimaryKey = new DataColumn[] { dtAlumnos.Columns["Legajo"] };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Cargo el dtCursos
            if (File.Exists(PATH_XML_CURSOS_ESQUEMA) && File.Exists(PATH_XML_CURSOS))
            {
                //Si existen los xml leo los archivos y los cargo al dtCurso
                dtCursos.ReadXmlSchema(PATH_XML_CURSOS_ESQUEMA);
                dtCursos.ReadXml(PATH_XML_CURSOS);
                MessageBox.Show("Datos cargados desde el XML");
            }
            else 
            {
                //Si no existen creo los archivos con los valores y los cargo al dtCursos
                dtCursos = this.CrearDataTableCurso();
                MessageBox.Show("Los archivos se crearon desde el metodo CrearDataTable y se cargaron a la tabla");
            }

            //Cargamos al dtAlumno y dtCursos al dataSet
            this._dataSetAlumnos_Cursos.Tables.Add(dtAlumnos);
            this._dataSetAlumnos_Cursos.Tables.Add(dtCursos);
        }

        public void EstablecerRelaciones()
        {
            //Primero se completa el padre despues el hijo //El padre esta dado segun la relacion
            //En este caso la relacion es un curso tiene muchos alumnos
            this._dataSetAlumnos_Cursos.Relations.Add("CursosAlumnos",this._dataSetAlumnos_Cursos.Tables["Cursos"].Columns["Codigo"],
                                                                      this._dataSetAlumnos_Cursos.Tables["Alumnos"].Columns["Curso"]);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this._dataSetAlumnos_Cursos = new DataSet();
            this.CondiguracionDataAdapter();
            this.TraerDatos();
            this.EstablecerRelaciones();
        }

        //Agregar Alumno
        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno frmAlu = new frmAlumno(this._dataSetAlumnos_Cursos.Tables["Cursos"]);

            if (frmAlu.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Genero una nueva fila 
                DataRow fila = this._dataSetAlumnos_Cursos.Tables["Alumnos"].NewRow();
                
                //Seteo los valores de la nueva fila
                fila["Legajo"] = frmAlu.UnAlumno.Legajo;
                fila["Apellido"] = frmAlu.UnAlumno.Apellido;
                fila["Curso"] = frmAlu.UnAlumno.Curso;

                //Agrego la nueva fila a la tabla Alumnos
                this._dataSetAlumnos_Cursos.Tables["Alumnos"].Rows.Add(fila);

                MessageBox.Show("Apellido "+frmAlu.UnAlumno.Apellido +" Legajo: "+ frmAlu.UnAlumno.Legajo + " Curso: "+frmAlu.UnAlumno.Curso);
            }
        }

        //Guardar Tablas
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this._dataAdapterAlumnos.Update(this._dataSetAlumnos_Cursos.Tables["Alumnos"]);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Base de datos Actualizada.");
        }

        //Mostrar Alumnos
        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar frMostrar = new frmMostrar(this._dataSetAlumnos_Cursos,EMostrar.Alumnos);
            frMostrar.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLegajo frmLegajo = new frmLegajo();

            if (frmLegajo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                Alumno alumnoBorrar;

                foreach (DataRow item in this._dataSetAlumnos_Cursos.Tables["Alumnos"].Rows)
                {
                    if ((int)item["Legajo"] == frmLegajo.Legajo)
                    {
                        alumnoBorrar = new Alumno(item["Apellido"].ToString(),(int)item["Curso"], (int)item["Legajo"]);

                        frmAlumno frmAlumnoBorrar = new frmAlumno(alumnoBorrar, this._dataSetAlumnos_Cursos.Tables["Cursos"]);

                        if (frmAlumnoBorrar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            MessageBox.Show("El legajo se encuentra en la base");
                            item.Delete();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El legajo no se encuentra en la base");
                    }
                }
            }
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLegajo frmLegajo = new frmLegajo();

            if (frmLegajo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                Alumno alumnoMod;

                foreach (DataRow item in this._dataSetAlumnos_Cursos.Tables["Alumnos"].Rows)
                {
                    if ((int)item["Legajo"] == frmLegajo.Legajo)
                    {
                        alumnoMod = new Alumno(item["Apellido"].ToString(), (int)item["Curso"], (int)item["Legajo"]);

                        frmAlumno frmAlumnoMod = new frmAlumno(alumnoMod, this._dataSetAlumnos_Cursos.Tables["Cursos"]);

                        if (frmAlumnoMod.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            MessageBox.Show("El legajo se encuentra en la base");
                            item["Legajo"] = frmAlumnoMod.UnAlumno.Legajo;
                            item["Apellido"] = frmAlumnoMod.UnAlumno.Apellido;
                            item["Curso"] = frmAlumnoMod.UnAlumno.Curso;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El legajo no se encuentra en la base");
                    }
                }
            }
        }

    }

}
