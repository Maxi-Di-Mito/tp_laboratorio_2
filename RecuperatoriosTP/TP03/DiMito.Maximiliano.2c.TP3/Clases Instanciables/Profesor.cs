using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public sealed class Profesor:Universitario
    {
        private Queue<Universidad.EClases> _clasesDelDia;
        private static Random _random;

        static Profesor()
        {
            Profesor._random = new Random();            
        }

        public Profesor()
        {
            _randomClases();
        }

        public Profesor(int id, String nombre, String apellido, String dni, ENacionalidad nacionalidad)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
            _randomClases();
        }

        private void _randomClases()
        {
            this._clasesDelDia = new Queue<Universidad.EClases>();
            this._clasesDelDia.Enqueue((Universidad.EClases)Profesor._random.Next(0, 3));
            this._clasesDelDia.Enqueue((Universidad.EClases)Profesor._random.Next(0, 3));
        }


        protected override string ParticiparEnClase()
        {
            StringBuilder builder = new StringBuilder();            
            builder.AppendLine("CLASES DEL DIA:");
            foreach(Universidad.EClases clase in this._clasesDelDia)
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



        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases c in i._clasesDelDia)
            {
                if (c == clase)
                    return true;
            }
            return false;
        }


        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        public String ToString()
        {
            return this.MostrarDatos();
        }

    }
}
