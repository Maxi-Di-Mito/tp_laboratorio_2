using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAle
{
    abstract class Persona
    {

        protected String nombre;


        public Persona(String n)
        {
            this.nombre = n;
        }

        public abstract String Profesion();

        public virtual String Mostrar()
        {
            return this.nombre;
        }

    }
}
