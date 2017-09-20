using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            int suma = 0;
            int numero;

            do
            {
                numero = pedirEntero();
                suma += numero;
                continuar = ValidarRespuesta.ValidarS_N();

            } while (continuar);
        }


        static int pedirEntero()
        {
            string input;
            int numero;
            bool errorParseo = false;
            do
            {
                if (errorParseo)
                    Console.WriteLine("Dato invalido");
                Console.WriteLine("Ingrese un numero entero");
                input = Console.ReadLine();
                errorParseo = !int.TryParse(input, out numero);
            } while (errorParseo);
            return numero;
        }
    }
}
