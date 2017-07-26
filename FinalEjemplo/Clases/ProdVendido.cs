using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ProdVendido:ProdExport
    {
        public string cliente;
        public ProdVendido(ProdExport pEx,string cliente) : base(new ProdImpuesto(pEx.nombre,pEx.stock,pEx.impuesto),pEx.pais)
        {
            this.cliente = cliente;
        }
    }
}
