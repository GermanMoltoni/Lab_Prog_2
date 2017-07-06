using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central
{
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
                
        }
        public string NroDestino
        {
            get { return this._nroDestino; }

        }
        public string NroOrigen
        {
            get { return this._nroOrigen; }

        }
        public abstract float CostoLlamada { get; }
        #endregion
        #region Constructor
        public Llamada(string origen,string destino,float duracion)
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
