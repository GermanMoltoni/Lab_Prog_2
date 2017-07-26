using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Producto
    {
        public string nombre;
        public int stock;


        public virtual int Stock
        {
            get {return 1 ; }
            set {; }
        }
        public Producto(string nombre,int stock)
        {
            this.nombre = nombre;
            this.stock = stock;
        }
    }
}
