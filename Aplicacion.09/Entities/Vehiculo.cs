using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entities
{
    [XmlInclude(typeof(Vehiculo))]
    [XmlInclude(typeof(Auto))]
    [XmlInclude(typeof(Camioneta))]
    [XmlInclude(typeof(Moto))]
    public class Vehiculo
    {

        #region Atributos
        private EColores _color;
        private String _marca;
        private String _patente;
        #endregion

        #region Propiedades
        public EColores Color
        {
            get { return this._color; }
        }

        public String Marca
        {
            get { return this._marca; }
        }

        public String Patente
        {
            get { return this._patente; }
        }
        #endregion

        #region Constructores
        public Vehiculo()
        { }

        public Vehiculo(String patente, String marca, EColores color)
        {
            this._patente = patente;
            this._marca = marca;
            this._color = color;
        }
        #endregion

        #region Metodos
        public int OrdenarPorPatente(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(v1._patente, v2._patente);
        }

        public override string ToString()
        {
            return "Marca: "+ this._marca+"--"+"Color: "+this._color+"--"+"Patente: "+this._patente;
        }
        #endregion
    }
}
