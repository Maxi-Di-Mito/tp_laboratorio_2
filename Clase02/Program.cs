using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelloName;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            string miMensaje;
            int error = 0;
            do
            {
                if (error == 0)
                    Console.WriteLine("Ingrese un mensaje");
                else
                    Console.WriteLine("Error, ingrese un mensaje valido");
                miMensaje = Console.ReadLine();
                error++;
            } while (!Sello.TryParse(miMensaje, out Sello.mensaje));

            Console.Clear();
            Sello.color = ConsoleColor.Cyan;
            Sello.ImprimirColor();
            Sello.Imprimir();

            Console.ReadKey();
        }
    }
}
