using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ClaseSegunda c = new ClaseSegunda("ALPEDO");
                c.InitCaos();
            }
            catch (MiException ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }
    }


    

}
