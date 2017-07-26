using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
namespace Deposito_Producto
{
    [Serializable]
    [XmlInclude(typeof(Producto))]
    public class Deposito
    {
        public Producto[] _productos;
        public Deposito() { }
        public Deposito(int espacio):this()
        {
            this._productos = new Producto[espacio];
        }
        public Producto[] Productos
        {
            get { return this._productos;}
        }
        public static Producto[] operator +(Deposito uno, Deposito dos)
        {
            bool flag = false;
            int i;
            Producto[] p = new Producto[uno._productos.Count()];
            uno._productos.CopyTo(p, 0);
            foreach(Producto prod in dos._productos)
            {
                flag = false;
                for(i=0; i<= p.Count()-1;i++)
                {
                    if (prod == p[i])
                    {
                        p[i].Stock += prod.Stock;
                        flag = false;
                    }
                    else
                        flag = true;
                }
                if (flag)
                {
                    Array.Resize(ref p, p.Count() + 1);
                    p[i] =prod;
                }
                
            }
            return p;
        }
    }
}
