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


            Console.ReadKey();
        }
    }
}
