using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Class2
    {
        private string nombre;
        public Class2()
        {
            this.nombre = "asdasd";
        }
        public static explicit operator string(Class2 a)
        {
            return a.nombre;
        }
    }
}
