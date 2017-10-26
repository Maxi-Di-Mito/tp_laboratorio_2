using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    sealed class Profesor:Universitario
    {
        private Queue<EClases> _clasesDelDia;
        private static Random _random;

        static Profesor()
        {
            Profesor._random = new Random();
        }

        private Profesor()
        {
            this._clasesDelDia = new Queue<EClases>();
            this._clasesDelDia.Enqueue((EClases)Profesor._random.Next(0, 3));
            this._clasesDelDia.Enqueue((EClases)Profesor._random.Next(0, 3));
        }

        public Profesor(int id, String nombre, String apellido, String dni, ENacionalidad nacionalidad)
            :base(id,nombre,apellido,dni,nacionalidad)
        {

        }

         


        protected override string ParticiparEnClase()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("CLASES DEL DIA:");
            foreach(EClases clase in this._clasesDelDia)
            {
                builder.AppendLine(clase.ToString());
            }
            return builder.ToString();
        }


        protected override string MostrarDatos()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(base.MostrarDatos());
            builder.AppendLine(this.ParticiparEnClase());            

            return builder.ToString();
        }



        public static bool operator ==(Profesor i, EClases clase)
        {
            return i._clasesDelDia.Contains(clase);
        }


        public static bool operator !=(Profesor i, EClases clase)
        {
            return !(i == clase);
        }

        public String ToString()
        {
            return this.MostrarDatos();
        }

    }
}
