using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP2017lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo("Lanus", new DirectorTecnico("Maxi", "Di Mito"));
            Jugador j1 = new Jugador("Alejandro", "Piñero");
            Jugador j2 = new Jugador("Pablo", "Perez",3,false);
            Jugador j3 = new Jugador("Fermin", "Rodriguez",10,true);

            equipo = equipo + j1;
            equipo = equipo + j2;
            equipo = equipo + j3;
            equipo = equipo + j1;

            Console.WriteLine(equipo);
            Console.ReadKey();
        }
    }
}
