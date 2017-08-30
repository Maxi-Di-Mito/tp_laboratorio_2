using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase5CampusProvisorio
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroDecimal numDecimal = 10.6;
            NumeroBinario numBinario = "1101";

            Console.WriteLine("Suma B + D :" + (numDecimal + numBinario));
            Console.WriteLine("Suma D + B :" + (numBinario + numDecimal));



        }
    }
}
