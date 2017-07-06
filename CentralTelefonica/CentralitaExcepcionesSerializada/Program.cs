using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Central;
namespace CentralitaExcepcionesSerializada
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita telefonica = new Centralita("Telefonica");
            telefonica.RutaDeArchivo = "CENTRALITA.XML";
            Local llamadaLocal1 = new Local("Avellaneda", 30, "Lanus", (float)2.65);
            Provincial llamadaProvincial1 = new Provincial("Buenos Aires", Franja.Franja_1, 21, "Santa Fe");
            Local llamadaLocal2 = new Local("Banfield", 45, "Quilmes", (float)1.99);
            Llamada llamadaProvincial2 = new Provincial(Franja.Franja_3, llamadaProvincial1);
            
            
            
            telefonica += llamadaLocal1;
             telefonica += llamadaProvincial1;

            //telefonica.Serializarse();
            //telefonica += llamadaProvincial2;
             Console.WriteLine(telefonica.ToString());
             telefonica.OrdenarLlamadas();
             Console.WriteLine(telefonica.ToString());
            Console.WriteLine(telefonica.ToString());
            telefonica.Serializarse();
            telefonica.DeSerializarse();
            Console.WriteLine(telefonica.ToString());

            Console.WriteLine("------------");
            Centralita.LeerDeArchivo();
            Console.Read();
        }
    }
}
