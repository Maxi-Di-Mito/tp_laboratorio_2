using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public class Alumno:PersonaGimnasio
    {
        EClases _claseQueToma;
        EEstadoCuenta _estadoCuenta;

        public Alumno(int id, string nombre,string apellido, string dni, ENacionalidad nacionalidad,EClases claseQueToma)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
            this._claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this._estadoCuenta = estadoCuenta;
        }

        public string ParticiparEnClase()
        {
            return "";
        }



        protected override string MostrarDatos()
        {
            return base.MostrarDatos();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static bool operator ==(Alumno a, EClases clase)
        {
            return true;
        }

        public static bool operator !=(Alumno a, EClases clase)
        {
            return !(a==clase);
        }

    }

    public enum EEstadoCuenta
    {
        AlDia,Deudor,MesPrueba
    }
}
