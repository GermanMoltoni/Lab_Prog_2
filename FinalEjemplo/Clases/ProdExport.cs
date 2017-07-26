using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ProdExport:ProdImpuesto
    {
        public string pais;
        public ProdExport(ProdImpuesto pI,string pais) : base(pI.nombre,pI.stock,pI.impuesto)
        {
            this.pais = pais;
        }
    }
}
