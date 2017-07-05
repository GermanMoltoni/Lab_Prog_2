using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial:Llamada
    {
        protected Franja _franjaHoraria;
        public float CostoLLamada {
            get { return this.CalcularCosto(); }
        }

        Provincial(Franja miFranja,Llamada unaLlamada):base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            this._franjaHoraria = miFranja;
        }
        Provincial(string origen,Franja miFranja,float duracion,string destino):this(miFranja,new Llamada(origen, destino, duracion)) { }






        float CalcularCosto() { }
        void Mostrar() { }
    }
}
