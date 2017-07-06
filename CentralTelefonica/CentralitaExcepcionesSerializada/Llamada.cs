using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
namespace Central
{
    [Serializable]
    [XmlInclude(typeof(Local))]
    [XmlInclude(typeof(Provincial))]
    public abstract class Llamada
    {
        #region Atributos
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion
        #region Propiedades
        public float Duracion {
            get { return this._duracion; }
            set { this._duracion = value; }
        }
        public string NroDestino
        {
            get { return this._nroDestino; }
            set { this._nroDestino = value; }
        }
        public string NroOrigen
        {
            get { return this._nroOrigen; }
            set { this._nroOrigen = value; }
        }
        public abstract float CostoLlamada { get; set; }
        #endregion
        #region Constructor
        public Llamada()
        {

        }
        public Llamada(string origen,string destino,float duracion):this()
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }
        #endregion
        #region Metodos
        protected virtual string Mostrar()
        {
            StringBuilder llamada = new StringBuilder();
            llamada.Append("Origen:"+this.NroOrigen+" Destino:"+this.NroDestino+" Duracion:"+this.Duracion.ToString());
            return llamada.ToString();
        }
        public static int OrdenarPorDuracion(Llamada uno,Llamada dos)
        {
            return uno.Duracion.CompareTo(dos.Duracion);
        }
        #endregion


        #region Sobrecargas
        public static bool operator ==(Llamada uno,Llamada dos)
        {
            return (uno.Equals(dos) && uno.NroDestino == dos.NroDestino && uno.NroOrigen == dos.NroOrigen);
        }
        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }
        #endregion
    }
}
