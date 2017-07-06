using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central
{
    public class Local:Llamada
    {
        protected float _costo;
        public override float CostoLlamada {
            get { return this.CalcularCosto(); }
        }
        public Local(Llamada unaLlamada,float costo):base(unaLlamada.NroOrigen,unaLlamada.NroDestino,unaLlamada.Duracion)
        {
            this._costo = costo;
        }
        public Local(string origen,float duracion,string destino,float costo):this(new Llamada(origen, destino, duracion), costo) { }
        private float CalcularCosto()
        {
            return base.Duracion * this._costo;
        }
        public override string Mostrar() {
            StringBuilder Local = new StringBuilder();
            Local.AppendLine(base.Mostrar());
            Local.AppendLine("Costo:"+this.CostoLlamada.ToString());
            return Local.ToString();
        }
    }
}
