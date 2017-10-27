using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Archivos;
using Excepciones;
using EntidadesAbstractas;
namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> _alumnos;
        private Universidad.EClases _clase;
        private Profesor _instructor;


        public List<Alumno> Alumnos
        {
            get
            {
                return this._alumnos;
            }
            set
            {
                this._alumnos = value;
            }
        }

        public Universidad.EClases Clase
        {
            get
            {
                return this._clase;
            }
            set
            {
                this._clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this._instructor;
            }
            set
            {
                this._instructor = value;
            }
        }

        private Jornada()
        {
            this._alumnos = new List<Alumno>();
        }


        public Jornada(Universidad.EClases clase, Profesor instructor)
            :this()
        {
            this._clase = clase;
            this._instructor = instructor;
        }


        public static String Leer()
        {
            Texto text = new Texto();
            String dato;
            if (text.Leer("jornada.txt", out dato))
            {
                return dato;
            }
            else
            {
                
            }
            return "";
        }

        public String ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Clase de " + this._clase.ToString() + " NOMBRE COMPLETO: " + this._instructor.ToString());
            builder.AppendLine("ALUMNOS:");
            foreach(Alumno a in this._alumnos)
            {
                builder.AppendLine(a.ToString());
            }
            builder.AppendLine("<---------------------------------------->");
            
            return "";
        }

        public static bool Guardar(Jornada jornada)
        {
            Texto text = new Texto();
            return text.Guardar("jornada.txt",jornada.ToString());            
        }

        


        /* OPERATORS*/

        public static bool operator ==(Jornada jornada, Alumno a)
        {
            foreach (Alumno al in jornada._alumnos)
            {
                if (Object.ReferenceEquals(al, a))
                    return true;
            }
            return false;
        }
        public static bool operator !=(Jornada jornada, Alumno a)
        {
            return !(jornada == a);
        }

        public static Jornada operator +(Jornada jornada, Alumno a)
        {
            if (jornada != a)
                jornada._alumnos.Add(a);

            return jornada;
        }


    }

    

}
