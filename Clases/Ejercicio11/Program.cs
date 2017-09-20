using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool errorParseo = false;
            bool errorValidacion = false;
            int numero;
            int maximo = 0;
            int minimo = 0;
            bool primerNumero = true;
            
            
            int suma = 0;
            string input;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    if (errorParseo || errorValidacion)
                        Console.WriteLine("Valor Invalido");

                    Console.WriteLine("Ingrese un numero");
                    input = Console.ReadLine();
                    errorParseo = !int.TryParse(input, out numero);
                    errorValidacion = !Validacion.Validar(100,-100,numero);                    
                } while (errorParseo || errorValidacion);
                
                suma += numero;
                if (primerNumero)
                {
                    maximo = numero;
                    minimo = numero;
                    primerNumero = false;
                }
                else 
                {
                    maximo = numero > maximo ? numero : maximo;
                    minimo = numero < minimo ? numero : minimo;
                }
            }

            Console.WriteLine("Maximo: {0}\nMinimo: {1}\nPromedio: {2}",maximo,minimo,suma/10.0);
            Console.ReadKey();
        }
    }
}
