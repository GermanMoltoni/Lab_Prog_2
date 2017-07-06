using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Central;
namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita telefonica = new Centralita("Telefonica");
            Local llamada1 = new Local("Banfield", 30, "Lanus", (float)2.65);
            Provincial llamada2 = new Provincial("Buenos Aires", Franja.Franja_1, 21, "Rio Negro");
            Local llamada3 = new Local(llamada1, (float)1.99);
            Provincial llamada4 = new Provincial(Franja.Franja_3, llamada2);
            telefonica.Llamadas.Add(llamada1);
            telefonica.Llamadas.Add(llamada2);
            telefonica.Llamadas.Add(llamada3);
            telefonica.Llamadas.Add(llamada4);
            Console.Write(telefonica.Mostrar());

            telefonica.OrdenarLLamadas();
            Console.Write(telefonica.Mostrar());
            Console.Read();
        }
    }
}
