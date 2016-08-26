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
            Producto p1 = new Producto(12.9, "asd123", "Cepillo de dientes");
            Producto p2 = new Producto(12.9, "qwe789");
            Producto p3 = new Producto(12.9);
            Producto p4 = new Producto();

            Producto p5 = new Producto(codigoDeBarras:"fgh345",precio: 10.3, nombre:"Mate");

            p1.Mostrar();
            p2.Mostrar();
            p3.Mostrar();
            p4.Mostrar();
            p5.Mostrar();

            Console.ReadKey();
        }
    }
}
