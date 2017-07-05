using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Llamada
    {
        #region Atributos
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion
        #region Propiedades
        public float Duracion { get; }
        public string NroDestino { get; }
        public string NroOrigen { get; }
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
        public void Mostrar()
        {

        }
        public int OrdenarPorDuracion(Llamada uno,Llamada dos)
        {

        }
        #endregion
    }
}
