using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int numero;
            do
            {
                Console.WriteLine("Ingrese un numero");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out numero));

            Console.WriteLine("Los numero primos menores a su numero son:");
            for (int i = 1; i < numero; i++)
            {
                if (esPrimo(i))
                    Console.WriteLine(i);
            }
            
            Console.ReadKey();
        }


        static bool esPrimo(int numero)
        {
            if (numero == 1)
                return true;
            else
            {
                for (int i = numero-1; i > 1; i--)
                {
                    if (numero % i == 0)
                        return false;
                }
                return true;
            }
                
        }

    }
}
