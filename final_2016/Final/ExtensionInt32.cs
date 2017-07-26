using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public static class ExtensionInt32
    {
        public static bool EsPar(this Int32 numero)
        {
            return (numero%2 == 0);
        }
        public static bool EsImpar(this Int32 numero)
        {
            return !numero.EsPar();
        }
    }
}
