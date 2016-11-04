using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    class Gimnasio
    {
        private List<Alumno> _alumnos;
        private List<Intructor> _instructores;
        private List<Jornada> _jornada;

        public Gimnasio()
        {
            this._alumnos = new List<Alumno>();
            this._instructores = new List<Intructor>();
            this._jornada = new List<Jornada>();
        }

        private static string MostrarDatos(Gimnasio gim)
        {
            return "";
        }

        public override string ToString()
        {
            return Gimnasio.MostrarDatos(this);
        }

    }

    public enum EClases
    {
        CrosFit,Natacion,Pilates
    }
}
