using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRespuesta
    {

        static public bool ValidarS_N()
        {
            bool errorParseo = false;
            char respuesta;
            do
            {
                if (errorParseo)
                    Console.WriteLine("Opcion no valida");
                respuesta = Console.ReadKey().KeyChar;                

            } while (!isS_N(respuesta));

            return respuesta == 's' || respuesta == 'S';
        }


        static private bool isS_N(char c)
        {
            return c == 's' || c == 'S' || c == 'n' || c == 'N';
        }
    }
}
