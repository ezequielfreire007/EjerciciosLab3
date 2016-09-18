using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entities
{
    [XmlInclude(typeof(Camioneta))]
    public class Camioneta:Vehiculo,ISerializable
    {
        #region Atributos
        private double _altura;
        #endregion

        #region Propiedades
        public double Altura
        {
            get { return this._altura; }
        }
        #endregion

        #region Constructores
        public Camioneta()
        { }

        public Camioneta(String patente, String marca, EColores color, double altura):base(patente,marca,color)
        {
            this._altura = altura;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return base.ToString() + "--" + "Altura: " + this._altura;
        }
        #endregion

        public bool Deserealizar(string ruta)
        {
            try
            {
                using (XmlTextReader lector = new XmlTextReader(ruta))
                {
                    XmlSerializer serializar = new XmlSerializer(typeof(Camioneta));
                    Camioneta aux;
                    aux = (Camioneta)serializar.Deserialize(lector);
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
                using (XmlTextWriter escritor = new XmlTextWriter(ruta, Encoding.UTF8))
                {
                    XmlSerializer serializar = new XmlSerializer(typeof(Camioneta));
                    serializar.Serialize(escritor, this);
                    return true;
                }
            }
            catch (Exception exe)
            {

                return false;
            }
            
        }
    }
}
