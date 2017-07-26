using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Burbujeo
{
    public class Usuario
    {
        public string password;
        public string nombre;
        public Usuario(string nombre,string password)
        {
            this.nombre = nombre;
            this.password = password;
        }
        public bool VerificarPassword(string pass)
        {
            if (this.password == pass)
                return true;
            throw new ClaveIncorrecta("La clave es incorrecta");
        }
        public static bool VerificarUsuario(Usuario u,string password)
        {
            try
            {
                return u.VerificarPassword(password);
            }
            catch(ClaveIncorrecta e)
            {
                throw e;
            }

        }


    }
}
