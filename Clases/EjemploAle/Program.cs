using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAle
{
    class Program
    {
        static void Main(string[] args)
        {
            Policia p = new Policia("Mati");
            Enfermero e = new Enfermero("Carlos");
           

            List<Persona> gente = new List<Persona>();

            gente.Add(p);
            gente.Add(e);
            


            foreach (Persona per in gente)
            {
                Console.WriteLine(per.Mostrar());
            }

            Console.ReadKey();

        }
    }
}
