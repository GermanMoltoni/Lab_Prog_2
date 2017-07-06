using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central
{
    [Serializable]
    public class Provincial:Llamada
    {
        protected Franja _franjaHoraria;
        public override float CostoLlamada {
            get { return this.CalcularCosto(); }
            set { ; }
        }
        public Franja FranjaHoraria { get { return this._franjaHoraria; }
            set { this._franjaHoraria = value; } }
        public Provincial()
        {

        }
        public Provincial(Franja miFranja,Llamada unaLlamada):this(unaLlamada.NroOrigen,miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        {
            
        }
        public Provincial(string origen,Franja miFranja,float duracion,string destino):base(origen, destino, duracion) {
            this._franjaHoraria = miFranja;
        }



        


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
        protected override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.Mostrar());
            cadena.AppendLine("Costo:" + this.CostoLlamada.ToString()+" Franja:"+this._franjaHoraria.ToString());
            return cadena.ToString();
        }
        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType());
        }
        public override string ToString()
        {
            return this.Mostrar().ToString();
        }
    }
}
