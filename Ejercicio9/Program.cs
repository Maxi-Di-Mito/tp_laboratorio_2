using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisos = 5;
            int contador = 1;
            string line = "";
            string input;
            do
            {
                 input = Console.ReadLine();
            }while(!Int32.TryParse(input, out pisos));
                        

            while (contador <= pisos)
            {
                line += "*";
                Console.WriteLine(line);
                contador++;
            }

            Console.ReadKey();
        }
    }
}
