using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random random = new Random();
            
            for (int i = 0; i < 20; i++)
            {
                numeros.Add(random.Next(100) -50);
            }

            Console.WriteLine("Como vienen");
            mostrar(numeros);

            List<int> listaFiltrada = numeros.FindAll((int n) =>
            {
                return n >= 0;
            });

            listaFiltrada.Sort( (int a, int b) =>
            {
                return b - a;
            });
            Console.WriteLine("Positivos ordenados descendiente");
            mostrar(listaFiltrada);


            listaFiltrada = numeros.FindAll((int n) =>
            {
                return n < 0;
            });

            listaFiltrada.Sort( (int a, int b) =>
            {
                return a - b;
            });

            Console.WriteLine("Negativos ordenados de forma creciente");
            mostrar(listaFiltrada);
            Console.ReadKey();

            /////////////////////


            Stack<int> pila = new Stack<int>();
            for (int i = 0; i < 20; i++)
            {
                pila.Push(random.Next(100) - 50);//nuemros en -49 y 50
            }
            
            



        }




        private static void mostrar(List<int> l)
        {
            foreach (int n in l)
            {
                Console.WriteLine(n);
            }
        }

    }
}
