using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using CentralitaExcepcionesSerializada;
namespace Central
{
    [Serializable]
    public class Centralita:ISerializable
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        private string _ruta;

        public string RutaDeArchivo {
            get { return this._ruta; }
            set { this._ruta = value; }
        }

        public float GananciaPorLocal { get {return this.CalcularGanancia(TipoLlamada.Local);}
            
        }
        public float GananciaPorProvincial { get { return this.CalcularGanancia(TipoLlamada.Provincial); }
             
        }
        public float GananciaTotal { get { return this.CalcularGanancia(TipoLlamada.Todas); }
             
        }
        public List<Llamada> Llamadas { get {return this._listaDeLlamadas; }
            set { this._listaDeLlamadas=value; }
        }

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
                            costo += ((Provincial)item).CostoLlamada;
                        break;
                    case TipoLlamada.Todas:
                        if (item is Provincial)
                            costo += ((Provincial)item).CostoLlamada;
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
                    centralita.AppendLine(((Local)llamada).ToString());
                if (llamada is Provincial)
                    centralita.AppendLine(((Provincial)llamada).ToString());
            }
            return centralita.ToString();

        }

        public void OrdenarLlamadas() {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
           this._listaDeLlamadas.Add(nuevaLlamada);
        }
        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            bool retorno = false;
            foreach(Llamada llamada in central.Llamadas)
            {
                if(llamada == nuevaLlamada)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }
        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if (central != nuevaLlamada)
            {
                central.AgregarLlamada(nuevaLlamada);
                
            }
            else
                Console.WriteLine("La llamada ya existe");
            return central;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool DeSerializarse()
        {
            Centralita centralitaNueva;
            using(XmlTextReader reader = new XmlTextReader(this.RutaDeArchivo))
            {
                XmlSerializer des = new XmlSerializer(typeof(Centralita));
                centralitaNueva = (Centralita)des.Deserialize(reader);
            }
            this._listaDeLlamadas = centralitaNueva._listaDeLlamadas;
            
            return false;
        }
        public bool Serializarse()
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(this.RutaDeArchivo.ToString(), System.Text.Encoding.UTF8))
                {
                    XmlSerializer serializa = new XmlSerializer(typeof(Centralita));
                    serializa.Serialize(writer, this);
                }
            }
            catch (Exception e)
            {
                
            }
            return true;    
        }
        private bool GuardarEnArchivo(Llamada unaLlamada,bool agrego)
        {
            return true;
        }
    }
}
