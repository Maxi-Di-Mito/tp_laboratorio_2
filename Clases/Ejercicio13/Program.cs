using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.DecimalBinario(4));

            Console.WriteLine(Conversor.BinarioDecimal("1010,1"));
            
            Console.ReadKey();
        }
    }
}
