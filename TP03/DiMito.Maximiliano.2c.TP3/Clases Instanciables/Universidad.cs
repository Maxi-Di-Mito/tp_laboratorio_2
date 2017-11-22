using Archivos;
using EntidadesAbstractas;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;


        public List<Alumno> Alumnos 
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }

        public Jornada this[int i]
        {
            get 
            { 
                return this.jornada[i]; 
            }
            set 
            { 
                jornada[i] = value; 
            }
        }

        public Universidad() 
        {
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
            this.jornada = new List<Jornada>();
        }

        public static bool Guardar( Universidad gim)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            return xml.Guardar("Universidad.xml",gim);
        }

        private static String MostrarDatos(Universidad g)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("JORNADA:");
            foreach (Jornada j in g.jornada)
            {
                builder.AppendLine(j.ToString());
            }
           /* builder.AppendLine("ALUMNOS:");
            foreach (Alumno a in g.alumnos)
            {
                builder.AppendLine(a.ToString());
            }*/
            return builder.ToString();
        }

        public String ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor p in g.profesores)
                if (Object.ReferenceEquals(p, i)) return true;
            return false;
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        public static Profesor operator ==(Universidad g, EClases clase)
        {
            foreach (Profesor p in g.profesores)
            {
                if (p == clase)
                    return p;
            }
            throw new SinProfesorException();
        }
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            foreach (Profesor p in g.profesores)
            {
                if (p != clase)
                    return p;
            }
            throw new SinProfesorException();
        }

        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno l in g.alumnos)
            {
                if (Object.ReferenceEquals(l, a)) return true;
                
            }
            return false;
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }


        public static Universidad operator +(Universidad g, Alumno a)
        {            
            if (g != a)
            {
                g.alumnos.Add(a);                
            }else 
                throw new AlumnoRepetidoException();
                         
            return g;
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor p = g == clase;
            Jornada j = new Jornada(clase, p);
            List<Alumno> losQueLaToman = new List<Alumno>();
            foreach (Alumno a in g.alumnos)
            {
                if (j != a && a == clase)
                {
                    j.Alumnos.Add(a);
                }
            }

            g.jornada.Add(j);
            return g;
        }

        public static Universidad operator +(Universidad g, Profesor i)
        {
            if (g != i)
                g.profesores.Add(i);
            return g;
        }

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

    }
}
