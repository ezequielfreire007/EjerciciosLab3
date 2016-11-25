using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Alumno
    {
        #region Atributos
        private String _apellido;
        private int _codCurso;
        private int _legajo;
        #endregion

        #region Propiedades
        public String Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public int Curso
        {
            get { return this._codCurso; }
            set { this._codCurso = value; }
        }

        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }
        #endregion

        #region Constructor
        public Alumno(String apellido, int codCurso, int legajo)
        {
            this._apellido = apellido;
            this._codCurso = codCurso;
            this._legajo = legajo;
        }
        #endregion
    }
}
