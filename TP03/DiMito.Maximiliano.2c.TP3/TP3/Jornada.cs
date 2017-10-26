using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Jornada
    {
        private List<Alumno> _alumnos;
        private EClases _clase;
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

        public EClases Clase
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


        public Jornada(EClases clase, Profesor instructor)
        {
            this._clase = clase;
            this._instructor = instructor;
        }


        public String Leer()
        {
            return "";
        }

        public String ToString()
        {
            return "";
        }

        /* OPERATORS*/

    }
}
