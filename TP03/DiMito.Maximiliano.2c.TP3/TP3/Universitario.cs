using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    abstract class Universitario:Persona
    {

        private int legajo;


        public Universitario()
        {
        }

        public Universitario(int legajo, String nombre, String apellido, String dni, ENacionalidad nacionalidad)
            :base(nombre,apellido,nacionalidad)
        {
            this.legajo = legajo;
            base.StringToDNI = dni;
        }



        protected virtual String MostrarDatos()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(base.ToString());
            builder.AppendLine("Legajo: " + this.legajo);
            return builder.ToString();
        }

        protected abstract String ParticiparEnClase();




        public override bool Equals(object obj)
        {
 	         if( obj is Universitario)
             {
                 Universitario un = (Universitario)obj;
                 return base.DNI == un.DNI && this.legajo == un.legajo;
             }else
             {
                 return false;
             }
        }


        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return pg1.Equals(pg2);
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

    }
}
