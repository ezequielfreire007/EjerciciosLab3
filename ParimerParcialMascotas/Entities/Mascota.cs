using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Mascota : Animal
    {
        #region Atributos
        private String _nombre;
        private eTipoDeMascota _tipoDeMascota;
        #endregion

        #region Propiedad
        public String Nombre
        {
            get { return this._nombre; }
        }

        public eTipoDeMascota TipoDeMascota
        {
            get { return this._tipoDeMascota; }
        }
        #endregion

        #region Constructor
        public Mascota(String nombre, eTipoDeMascota tipo, int edad):base(edad)
        {
            this._nombre = nombre;
            this._tipoDeMascota = tipo;
        }
        #endregion

        #region Metodos
        public static int OrdenarPorEdad(Mascota mascotaUno, Mascota mascotaDos)
        {
            int retorno = 0;
            if (mascotaUno.Edad > mascotaUno.Edad)
            {
                retorno = 1;
            }
            if (mascotaUno.Edad < mascotaDos.Edad)
            {
                retorno = -1;
            }
            return retorno;
        }

        public static int OrdenarPorNombre(Mascota mascotaUno, Mascota mascotaDos)
        {
            return String.Compare(mascotaUno._nombre, mascotaDos._nombre);
        }

        public static int OrdenarPorTipo(Mascota mascotaUno, Mascota mascotaDos)
        {
            int retorno = 0;

            if (mascotaUno._tipoDeMascota > mascotaDos._tipoDeMascota)
            {
                retorno = 1;
            }
            if (mascotaUno._tipoDeMascota < mascotaDos._tipoDeMascota)
            {
                retorno = -1;
            }

            return retorno;
        }

        public override string ToString()
        {
            return this._nombre +base.ToString()+this._tipoDeMascota;
        }
        #endregion

    }
}
