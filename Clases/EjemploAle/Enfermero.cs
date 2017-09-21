using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAle
{
    class Enfermero:Persona
    {

        public Enfermero(String n)
            : base(n)
        {

        }


        public override string Profesion()
        {
            return "Enfermero";
        }

        public override string Mostrar()
        {
            return base.Mostrar() + ", " + this.Profesion();
        }

    }
}
