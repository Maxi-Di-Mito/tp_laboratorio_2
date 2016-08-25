using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rec = new Rectangulo(5,12);
            
            Triangulo tri = new Triangulo(5,15);

            //Rectangulo.Dibujar(rec);

            Triangulo.Dibujar(tri);

            Console.ReadKey();
        }
    }
}
