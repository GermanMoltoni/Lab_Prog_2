using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbujeo
{
    public class ClaveIncorrecta : Exception
    {
    
        public ClaveIncorrecta(string mensaje):base(mensaje)
        {

        }
    }
}
