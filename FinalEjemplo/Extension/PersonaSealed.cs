using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public sealed class PersonaSealed
    {
        public string nombre;
        public PersonaSealed(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
