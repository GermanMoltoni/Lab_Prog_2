using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extension;
using DepositoProd;
using Clases;
using Eventos;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Punto 1
            Console.Write("\n--------------------Punto 1---------------\n");
            PersonaSealed p = new PersonaSealed("German");
            p.Mostrar();
            #endregion
            #region Punto 2
            Console.Write("\n--------------------Punto 2---------------\n");
            Queue<Double> cola = new Queue<double>();
            cola.Enqueue(5);
            cola.Enqueue(2);
            cola.Enqueue(4);
            foreach (double d in cola)
                Console.Write(d);
            cola.Enqueue(cola.Dequeue());
            Stack<Double> pila = new Stack<double>();
            for (int i = 0; i < cola.Count; i++)
                pila.Push(cola.Dequeue());
            for (int i = 0; i < pila.Count+1; i++)
                cola.Enqueue(pila.Pop());
            foreach (double d in cola)
                Console.Write(d);
            #endregion
            Console.Write("\n--------------------Punto 3---------------\n");
            Deposito d1 = new Deposito();
            d1.productos[0] = new DepositoProd.Producto("Gelatina", 2);
            d1.productos[1] = new DepositoProd.Producto("Chocolate", 2);
            d1.productos[2] = new DepositoProd.Producto("Anana", 2);
            Deposito d2 = new Deposito();
            d2.productos[0] = new DepositoProd.Producto("Dulce", 2);
            d2.productos[1] = new DepositoProd.Producto("Chocolate", 2);
            d2.productos[2] = new DepositoProd.Producto("Anana", 2);
            DepositoProd.Producto[] array = d1 + d2;
            foreach (DepositoProd.Producto prod in array)
                Console.WriteLine(prod.nombre);
            Console.Write("\n--------------------Punto 4---------------\n");
            Clases.Producto pro = new Clases.Producto("Pala", 22);
            ProdImpuesto pI = new ProdImpuesto(pro.nombre, pro.stock,(float)600.33);
            ProdExport pEX = new ProdExport(pI, "Argentina");
            ProdVendido pp = new ProdVendido(pEX, "Cliente Juan");
            Console.Write("\n--------------------Punto 5---------------\n");
            Galpon<Clases.Producto> g = new Galpon<Clases.Producto>();
            g.EsImpar += (Program.Delegad);
            g.Cantidad = 4;
            Console.Read();
           
        }
        public static void Delegad(int o, EventArgs e)
        {
            Console.WriteLine("esIMpar");
        }
    }
}
