using Archivos;
using EntidadesAbstractas;
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

        public Universidad() { }

        public static bool Guardar( Universidad gim)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            return xml.Guardar("Universidad.xml",gim);
        }

        private String MostrarDatos()
        {
            StringBuilder builder = new StringBuilder();


            return builder.ToString();
        }


        public static bool operator ==(Universidad g, Profesor i)
        {
            return true;
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return true;
        }
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            return new Profesor(1, "Maxi", "Di Mito", "35639526", Persona.ENacionalidad.Argentino);
        }
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            return new Profesor(1, "Maxi", "Di Mito", "35639526", Persona.ENacionalidad.Argentino);
        }
        public static bool operator ==(Universidad g, Alumno a)
        {
            return true;
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return true;
        }


        public static Universidad operator +(Universidad g, Alumno a)
        {

        }

        public static Universidad operator +(Universidad g, EClases clase)
        {

        }

        public static Universidad operator +(Universidad g, Profesor i)
        {

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
