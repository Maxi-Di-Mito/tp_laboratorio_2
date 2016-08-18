using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        static string ArmarFormatoMensaje()
        {
            string bar = new String('*', Sello.mensaje.Length + 2 );
            string cadena = bar + "\n" + "*" + Sello.mensaje + "*\n" + bar;
            return cadena;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirColor()
        {
            ConsoleColor colorAnterior = Console.ForegroundColor;
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.mensaje);
            Console.ForegroundColor = colorAnterior;
        }

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

    }
}
