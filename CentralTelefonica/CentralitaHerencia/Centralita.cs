using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal { get {; } }
        public float GananciaPorProvincial { get {; } }
        public float GananciaTotal { get {; } }
        public List<Llamada> MyProperty { get {; } }

        Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }
        Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }
        private float CalcularGanancia(TipoLlamada tipo) { }
        void Mostrar() { }
        void OrdenarLLamadas() { }

    }
}
