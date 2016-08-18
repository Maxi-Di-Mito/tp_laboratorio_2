using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola mundo";

            Sello.color = ConsoleColor.Cyan;
            Sello.ImprimirColor();

            Console.WriteLine(Sello.Imprimir());            

            Console.ReadKey();
        }
    }
}
