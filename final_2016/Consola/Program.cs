using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deposito_Producto;
using GalponEj;
using System.IO;
using Burbujeo;
using System.Threading;
using Herencia;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {


            using (StreamWriter outputFile = new StreamWriter("WriteLines.txt", true))
            {
                outputFile.WriteLine("Fourth Line");
            }
            #region Punto 2
            Stack<Double> pila = new Stack<Double>();
            pila.Push(3);
            pila.Push(2);
            pila.Push(1);
            Queue<Double> cola = new Queue<double>();
            foreach (Double d in pila)
                Console.Write(d);
            for (int i = 0; i <= pila.Count+1; i++)
                cola.Enqueue(pila.Pop());
            Console.WriteLine("");
            for (int i = 0; i <= cola.Count+1; i++)
                pila.Push(cola.Dequeue());
            foreach (Double d in pila)
                Console.Write(d);
            #endregion
            Producto pera = new Producto("pera", 2);
            Producto manzana = new Producto("Manzana", 1);
            Producto manzana1 = new Producto("Manzana", 3);
            Producto anana = new Producto("Anana", 1);

            Console.WriteLine("-----------------------------------");

            Console.WriteLine((int)pera);
            Console.WriteLine(pera);


            Console.WriteLine("-----------------------------------");







            Deposito d1 = new Deposito(2);
            d1.Productos[0] = pera;
            d1.Productos[1] = manzana;

            //d1.Productos[2] = manzana;
            Deposito d2 = new Deposito(2);
            d2.Productos[0] = manzana1;
            d2.Productos[1] = anana;
            //d2.Productos[2] = anana;


            Producto[] productos = d1 + d2;
            foreach (Producto p in productos)
                Console.WriteLine(p.Nombre+" "+p.Stock);
          


             
                Galpon<Deposito> g = new Galpon<Deposito>(2);
                g.EImpar += Impar;
                g.AddElement(d1);
                Thread t = new Thread(g.SerializarXML);
            t.Start();
            Thread.Sleep(100);
            while(!t.IsAlive)
                t.Abort();
               
             
            
            Usuario u = new Usuario("German", "123");
            try
            {
                Usuario.VerificarUsuario(u, "123");
                Console.WriteLine("correcta");
            }
            catch(ClaveIncorrecta c)
            {
                Console.WriteLine(c.Message);
            }



            Class1 a = new Class1();
            a.Hola();


            Console.Read();


        }
        public static void Impar(object o, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("log.txt");
            writer.WriteLine("{0:hh:mm:ss } {1}",DateTime.Now, o);
            writer.Close();
        }

       
        /*
         
         int.tryparse(entrada,out numero);
         indexador public Clase this[int i]{
         get
         set
         }
         cmb.datasource = enum.getvalues(typeof(enum))
         
         
         
         
         */
    }
}
