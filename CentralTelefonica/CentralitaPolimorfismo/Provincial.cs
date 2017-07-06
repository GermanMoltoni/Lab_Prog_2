using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central
{
    public class Provincial:Llamada
    {
        protected Franja _franjaHoraria;
        public float CostoLLamada {
            get { return this.CalcularCosto(); }
        }

        public Provincial(Franja miFranja,Llamada unaLlamada):base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            this._franjaHoraria = miFranja;
        }
        public Provincial(string origen,Franja miFranja,float duracion,string destino):this(miFranja,new Llamada(origen, destino, duracion)) { }



        


        private float CalcularCosto() {
            float costo=0;
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = base.Duracion * (float)0.99;
                    break;
                case Franja.Franja_2:
                    costo = base.Duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    costo = base.Duracion *(float) 0.66;
                    break;
                default:
                    break;
            }
            return costo;

        }
        public override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.Mostrar());
            cadena.AppendLine("Costo:" + this.CostoLLamada.ToString()+" Franja:"+this._franjaHoraria.ToString());
            return cadena.ToString();
        }
    }
}
