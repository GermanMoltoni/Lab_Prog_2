using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local:Llamada
    {
        protected float _costo;
        public float CostoLlamada {
            get { return this.CalcularCosto(); }
        }
        Local(Llamada unaLlamada,float costo):base(unaLlamada.NroOrigen,unaLlamada.NroDestino,unaLlamada.Duracion)
        {
            this._costo = costo;
        }
        Local(string origen,float duracion,string destino,float costo):this(new Llamada(origen, destino, duracion), costo) { }
        private float CalcularCosto()
        {

        }
        void Mostrar() { }
    }
}
