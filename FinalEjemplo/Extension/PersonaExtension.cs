using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class PersonaExtension
    {
        public static void Mostrar(this PersonaSealed p)
        {
            Console.Write(p.nombre);
        }
    }
}
