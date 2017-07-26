using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositoProd
{
    public class Deposito
    {
        public Producto[] productos;
        public Deposito()
        {
            this.productos = new Producto[3];
        }
        public  Producto this[int i]
        {
            get { return this.productos[i]; }
        }
        public static Producto[] operator +(Deposito uno,Deposito dos)
        {
           
            bool flag = false;
            Producto[] p = uno.productos;
           // uno.productos.CopyTo(p,0);
            foreach(Producto prDos in dos.productos)
            {
                foreach (Producto pr in p)
                {
                    if (pr == prDos)
                    {
                        pr.stock += prDos.stock;
                        flag = false;
                        break;
                    }
                    else
                        flag = true;
                }
                if(flag)
                {
                    Array.Resize(ref p,p.Count()+1);
                    p.SetValue(prDos,p.Count()-1);
                    flag = false;
                }
            }
            return p;           
        }
    }
}
