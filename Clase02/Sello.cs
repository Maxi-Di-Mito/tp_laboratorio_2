using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelloName
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        static string ArmarFormatoMensaje()
        {
            string bar = new String('*', Sello.mensaje.Length + 2 );
            string cadena = bar + "\n" + "*" + Sello.mensaje + "*\n" + bar + "\n";
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
            Console.WriteLine(Sello.ArmarFormatoMensaje());
            Console.ForegroundColor = colorAnterior;
        }

        public static void Imprimir()
        {
            Console.WriteLine(Sello.ArmarFormatoMensaje());
        }

        public static bool TryParse(string m, out string ret)
        {
            if (string.IsNullOrEmpty(m))
            {
                ret = null;
                return false;
            }
            ret = m;
            return true;
        }


    }
}
