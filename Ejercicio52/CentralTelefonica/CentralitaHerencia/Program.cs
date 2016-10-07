using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita c = new Centralita("Telefonica");
            Llamada l1 = new Local("lanus", 30f, "avellaneda", 2.65f);
            Llamada l2 = new Provincial("quilmes",Franja.Franja_1, 21f,"CABA");
            Llamada l3 = new Local("escalada",45f,"lomas de zamora",1.99f);
            Llamada l4 = new Provincial(Franja.Franja_3, l2);

            c.Llamadas.Add(l1);
            c.Llamadas.Add(l2);
            c.Llamadas.Add(l3);
            c.Llamadas.Add(l4);

            c.Mostrar();

            Console.WriteLine("\n ORDENO LAS LLAMADAS");
            c.OrdenarLlamadas();

            c.Mostrar();

            Console.ReadKey();
        }
    }
}
