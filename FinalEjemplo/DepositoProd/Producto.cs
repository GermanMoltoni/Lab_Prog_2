using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositoProd
{
    public class Producto
    {
        public string nombre;
        public int stock;
        public Producto(string nombre,int stock)
        {
            this.nombre = nombre;
            this.stock = stock;
        }
        public static bool operator ==(Producto uno,Producto dos)
        {
            if (uno.Equals(null) || dos.Equals(null))
                return false;
            return (uno.nombre == dos.nombre);
        }
        public static bool operator !=(Producto uno, Producto dos)
        {
            return !(uno == dos);
        }
    }
}
