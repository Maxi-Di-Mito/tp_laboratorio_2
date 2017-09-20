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
            int pisos;            
            string line = "";
            string input;
            
            do
            {
                 input = Console.ReadLine();
            }while(!int.TryParse(input, out pisos));


            for (int i = 0; i < pisos;i++ )
            {
                line = line + "*";
                Console.WriteLine(line);                
            }

            Console.ReadKey();
        }
    }
}
