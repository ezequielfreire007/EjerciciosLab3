using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entities
{
    [XmlInclude(typeof(Moto))]
    public class Moto:Vehiculo,ISerializable
    {
        #region Atributos
        private Single _cilindrada;
        #endregion

        #region Propiedades
        public Single Cilindrada
        {
            get { return this._cilindrada; }
        }
        #endregion

        #region Constructores
        public Moto()
        { }

        public Moto(String patente, String marca, EColores color, Single cilindrada):base(patente,marca,color)
        {
            this._cilindrada = cilindrada;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return base.ToString() + "--" + "Cilindrada: " + this._cilindrada;
        }

        #endregion
        public bool Deserealizar(string ruta)
        {
            try
            {
                using (XmlTextReader lector = new XmlTextReader(ruta))
                {
                    XmlSerializer serializar = new XmlSerializer(typeof(Moto));
                    Moto aux;
                    aux = (Moto)serializar.Deserialize(lector);
                    return true;
                }
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public bool Serializar(string ruta)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(ruta,Encoding.UTF8))
                {
                    XmlSerializer serializar = new XmlSerializer(typeof(Moto));
                    serializar.Serialize(escritor,this);
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
