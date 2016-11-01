using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Mascota : Animal
    {
        #region Atributo
        private String _nombre;
        private eTipoDeMascota _tipoDeMascota;
        #endregion

        #region Propiedades
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
        public Mascota(String nombre, eTipoDeMascota tipo, int edad)
            : base(edad)
        {
            this._nombre = nombre;
            this._tipoDeMascota = tipo;
        }
        #endregion

        #region Metodos
        public static int OrdenarPorEdad(Mascota unaMascota, Mascota dosMascota)
        {
            int retorno = 0;

            if (unaMascota.Edad > dosMascota.Edad)
            {
                retorno = 1;
            }

            if (unaMascota.Edad < dosMascota.Edad)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int OrdenarPorNombre(Mascota unaMascota, Mascota dosMascota)
        {
            return String.Compare(unaMascota._nombre,dosMascota._nombre);
        }

        public static int OrdenarPorTipo(Mascota unaMascota, Mascota dosMascota)
        {
            int retorno = 0;

            if (unaMascota._tipoDeMascota == eTipoDeMascota.exotica)
            {
                retorno = 1;
            }

            if (unaMascota._tipoDeMascota == eTipoDeMascota.horagareña)
            {
                retorno = -1;
            }
            return retorno;
        }
        
        public override string ToString()
        {
            return base.ToString() +" "+ "Nombre: " + this._nombre +" "+"Tipo: " + this._tipoDeMascota;
        }
        #endregion
    }
}
