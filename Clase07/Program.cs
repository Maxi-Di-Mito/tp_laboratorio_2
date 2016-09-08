using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] colores = {ConsoleColor.Black, ConsoleColor.Cyan, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkMagenta};
            string[] nombres = {"Hasbro","Parker","Chevrolet","Parker","Lumilagro"};
            sbyte[] cantidades = { 1,2,3,4,5};

            Tempera[] temperas = new Tempera[5];
            
            for (int i = 0; i < temperas.Length; i++)
            {
                temperas[i] = new Tempera(colores[i],nombres[i],cantidades[i]);
            }

            /*foreach (Tempera t in temperas)
            {
                Console.WriteLine(t);
            }*/

            Paleta p = 8;
            Console.WriteLine((string)p);

            Console.ReadKey();
        }
    }
}
