using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ProdImpuesto:Producto
    {
        public float impuesto;
        public ProdImpuesto(string nombre,int stock,float impuesto) : base(nombre,stock)
        {
            this.impuesto = impuesto;
        }
    }
}
