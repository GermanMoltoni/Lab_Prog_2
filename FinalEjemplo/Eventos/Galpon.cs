using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public delegate void DelegadoImPar(int o, EventArgs e);
    public class Galpon<T>
    {
        
        public event DelegadoImPar EsImpar;

        public List<T> lista;
        private int _cantidad;
   
        public int Cantidad {
            set {
                if (value == 0)
                    throw new ArgumentException("Es cero");
                else
                {
                    if (value % 2 == 0)
                    {

                    }
                    else
                    {
                        this.EsImpar(1,new EventArgs());
                    }
                    this._cantidad = value;
                }

                }
        }
    }

}
