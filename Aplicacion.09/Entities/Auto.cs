using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entities
{
    [XmlInclude(typeof(Auto))]
    public class Auto:Vehiculo, ISerializable
    {
        #region Atributos
        private int _cantidadPuertas;
        #endregion

        #region Propiedades
        public int CantidadPuertas
        {
            get { return this._cantidadPuertas; }
        }
        #endregion

        #region Constructores
        public Auto()
        {
 
        }

        public Auto(String patente, String marca, EColores color,int cantidadPuertas):base(patente,marca,color)
        {
            this._cantidadPuertas = cantidadPuertas;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return base.ToString()+"--"+"Cantidad: "+this._cantidadPuertas;
        }
        #endregion

        public bool Deserealizar(string ruta)
        {
            try
            {
                using (XmlTextReader lector = new XmlTextReader(ruta))
                {
                    XmlSerializer serializar = new XmlSerializer(typeof(Auto));
                    Auto aux;
                    aux = (Auto)serializar.Deserialize(lector);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
                
            }

            throw new NotImplementedException();
        }

        public bool Serializar(string ruta)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(ruta, Encoding.UTF8))
                {
                    XmlSerializer serializar = new XmlSerializer(typeof(Auto));
                    serializar.Serialize(escritor, this);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
