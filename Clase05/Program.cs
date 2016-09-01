using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta t = new Tinta();
            Tinta t2 = new Tinta(ETipoTinta.ConBrillito,ConsoleColor.Blue);
            Tinta t3 = new Tinta(ETipoTinta.ConBrillito, ConsoleColor.Blue);
            
            Console.WriteLine(Tinta.Mostrar(t));
            Console.WriteLine(Tinta.Mostrar(t2));
            Console.WriteLine(Tinta.Mostrar(t3));

            Console.WriteLine("t2 con t3");
            if (t2 == t3)
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("No son iguales");

            Console.WriteLine("t2 con t1");
            if (t2 == t)
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("No son iguales");


            Console.WriteLine(t);

            Console.WriteLine("\n------------------------------\n\n");

            Pluma p = new Pluma("Parker", t, 1);

            Console.WriteLine(p);
            Console.WriteLine((string)p);

            Console.WriteLine("P con t1");
            if (p == t)
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("No son iguales");


            Console.WriteLine("P sumo t1");
            p = p + t;
            Console.WriteLine(p);

            Console.WriteLine("P rest0 t1");
            p = p - t;
            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
