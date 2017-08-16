using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisos = 5;
            int contador = 1;
            string line = "*";
            string input;
            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out pisos));
            
            line = line.Insert(0,new String(' ',pisos-1));
            
            while (contador <= pisos)
            {               
                Console.WriteLine(line);                
                line = line.Substring(1, line.Length-1) + "**";
                contador++;
            }

            Console.ReadKey();
        }
    }
}
