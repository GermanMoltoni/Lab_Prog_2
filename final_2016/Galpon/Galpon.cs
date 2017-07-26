using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extension;
using System.Xml;
using System.Xml.Serialization;
namespace GalponEj
{
    public delegate void EsImpar(object o, EventArgs e);

    [Serializable]
    public class Galpon<T> : IGuardarXML
    {

        public event EsImpar EImpar;
        public List<T> _lista;
        public Int32 cantidad;
        public Galpon() { }
        public Galpon(int cant)
        {
            try
            {
                this.Cantidad = cant;
            }
            catch(Exception e)
            {
                throw e;
            }
            this._lista = new List<T>();
            
        }
        public Int32 Cantidad
        {
            get { return this.cantidad; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("El valor ingresado es 0");
                if(value.EsPar())
                {
                    this.cantidad = value;
                }
                if(value.EsImpar())
                {
                    this.EImpar(value, new EventArgs());
                    this.cantidad = value;
                }

            }

        }

        public void AddElement(T e)
        {
            if(this._lista.Count < this.cantidad)
            {
                this._lista.Add(e);
            }
        }
        public void SerializarXML()
        {
            using (XmlTextWriter writer = new XmlTextWriter("archivo.xml", System.Text.Encoding.UTF8))
            {
                XmlSerializer serial = new XmlSerializer(typeof(Galpon<T>));
                serial.Serialize(writer,this);
            }
            
        }
    }
}
