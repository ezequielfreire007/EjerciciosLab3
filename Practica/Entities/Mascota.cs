using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Mascota:Animal
    {
        private String _nombre;
        private eTipoDeMascota _tipo;

        public Mascota(String nombre, eTipoDeMascota tipo, int edad):base(edad)
        {
            this._nombre = nombre;
            this._tipo = tipo;
        }

        public static int OrdenarPorEdad(Mascota mascota, Mascota mascotaDos)
        {
            int retorno = 0;
            if (mascota.Edad > mascotaDos.Edad)
            {
                retorno = 1;
            }

            if (mascota.Edad < mascotaDos.Edad)
            {
                retorno = -1;
            }
            return retorno;
        }

        public static int OrdenarPorNombre(Mascota mascota, Mascota mascotaDos)
        {
            return String.Compare(mascota._nombre,mascotaDos._nombre);
        }

        public static int OrdenarPorTipo(Mascota mascota, Mascota mascotaDos)
        {
            int retorno = 0;
            if (mascota._tipo == eTipoDeMascota.hogareña)
            {
                retorno = 1;
            }
            if (mascota._tipo == eTipoDeMascota.exotica)
            {
                retorno = -1;
            }

            return retorno;
        }

        public override string ToString()
        {
            return this._nombre +" "+base.ToString() +" "+this._tipo;
        }
    }
}
