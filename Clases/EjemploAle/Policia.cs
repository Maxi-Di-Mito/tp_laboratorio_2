using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAle
{
    class Policia:Persona
    {

        public Policia(String n)
            : base(n)
        {
        }


        public override string Profesion()
        {
            return "POLICIA";
        }


        public override String Mostrar()
        {
            return base.Mostrar() + ", " + this.Profesion();
        }

    }
}
