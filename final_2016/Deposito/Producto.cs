using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito_Producto
{
    [Serializable]
    public class Producto
    {
        private string _nombre;
        private int _stock;
 
        public Producto() { }
        public Producto(string nombre,int stock):this()
        {
            this._nombre = nombre;
            this._stock = stock;
       
        }
        public int Stock
        {
            get { return this._stock; }
            set { this._stock = value; }
        }
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public static bool operator ==(Producto uno,Producto dos)
        {
            if (uno.Equals(null) || dos.Equals(null))
                return false;
            return (uno._nombre == dos._nombre);
        }
        public static bool operator !=(Producto uno, Producto dos)
        {
            return !(uno == dos);
        }


        public static implicit operator string(Producto a)
        {
            return a.Nombre;
        }
        public static explicit operator int(Producto a)
        {
            return a.Stock;
        }

    }
}
