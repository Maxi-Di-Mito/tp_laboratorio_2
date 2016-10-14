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

            c +=l1;
            c +=l2;
            c +=l3;
            c +=l4;

            Console.WriteLine(c);

            Console.WriteLine("\n ORDENO LAS LLAMADAS");
            c.OrdenarLlamadas();

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
