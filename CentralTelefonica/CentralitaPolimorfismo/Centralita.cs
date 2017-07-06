﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal { get {return this.CalcularGanancia(TipoLlamada.Local); } }
        public float GananciaPorProvincial { get { return this.CalcularGanancia(TipoLlamada.Provincial); } }
        public float GananciaTotal { get { return this.CalcularGanancia(TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get {return this._listaDeLlamadas; } }

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }
        private float CalcularGanancia(TipoLlamada tipo) {
            float costo = 0;
            foreach (Llamada item in this.Llamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if (item is Local)
                            costo += ((Local)item).CostoLlamada;
                        break;
                    case TipoLlamada.Provincial:
                        if (item is Provincial)
                            costo += ((Provincial)item).CostoLLamada;
                        break;
                    case TipoLlamada.Todas:
                        if (item is Provincial)
                            costo += ((Provincial)item).CostoLLamada;
                        if (item is Local)
                            costo += ((Local)item).CostoLlamada;
                        break;
                    default:
                        break;
                }
            }
            return costo;
        }
        public string Mostrar()
        {
            StringBuilder centralita = new StringBuilder();
            centralita.AppendLine("Razon_Social:"+this._razonSocial+" Ganancia_Total:"+this.GananciaTotal.ToString());
            centralita.AppendLine("Ganancia_Local:" + this.GananciaPorLocal.ToString() + " Ganancia_Provincial:" + this.GananciaPorProvincial.ToString());
            foreach(Llamada llamada in this.Llamadas)
            {
                if (llamada is Local)
                    centralita.AppendLine(((Local)llamada).Mostrar());
                if (llamada is Provincial)
                    centralita.AppendLine(((Provincial)llamada).Mostrar());
            }
            return centralita.ToString();

        }

        public void OrdenarLLamadas() {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

    }
}
