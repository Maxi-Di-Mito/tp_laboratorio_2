using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_FinalLab2
{
    public abstract class Persona
    {
        protected String apellido;
        protected String nombre;

        public Persona(String nombre, String apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }


        public override string ToString()
        {
            return nombre + ", " + apellido;
        }
    }
}
