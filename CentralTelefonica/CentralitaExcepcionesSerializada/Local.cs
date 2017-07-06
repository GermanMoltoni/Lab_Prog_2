using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central
{
    [Serializable]
    public class Local:Llamada
    {
        protected float _costo;
        public override float CostoLlamada {
            get { return this.CalcularCosto(); }
            set { ;}
        }
        public float Costo
        {
            get { return this._costo; }
            set { this._costo=value; }
        }
        public Local():base()
        {

        }
        public Local(string origen, float duracion, string destino, float costo)
           : base(origen, destino, duracion)
        {
            this._costo = costo;
        }
        public Local(Llamada unaLlamada, float costo) : this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        { }
        private float CalcularCosto()
        {
            return base.Duracion * this._costo;
        }
        protected override string Mostrar() {
            StringBuilder Local = new StringBuilder();
            Local.AppendLine(base.Mostrar());
            Local.AppendLine("Costo:"+this.CostoLlamada.ToString());
            return Local.ToString();
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
