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
            int pisos;
            string line = "*";
            string input;
            do
            {
                input = Console.ReadLine();
            } while (!int.TryParse(input, out pisos));
            
            line = line.Insert(0,new String(' ',pisos-1));

            for (int i = 0; i < pisos; i++ )
            {
                Console.WriteLine(line);
                line = line.Substring(1, line.Length - 1) + "**";                
            }

            Console.ReadKey();
        }
    }
}
