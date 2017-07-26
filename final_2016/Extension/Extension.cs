using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class Extension
    {
        public static bool EsPar(this Int32 numero)
        {
            return (numero % 2 == 0);
        }
        public static bool EsImpar(this Int32 numero)
        {
            return !numero.EsPar();
        }
    }
}
