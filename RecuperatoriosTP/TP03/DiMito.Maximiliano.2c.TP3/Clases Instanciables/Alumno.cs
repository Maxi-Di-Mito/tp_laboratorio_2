using EntidadesAbstractas;
using ClasesInstanciables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public sealed class Alumno: Universitario
    {
        private Universidad.EClases _claseQueToma;
        private EEstadoCuenta _estadoCuenta;

        public Alumno(){}

        public Alumno(int id, String nombre, String apellido, String dni, ENacionalidad nacionalidad, Universidad.EClases claseQueTome)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
            this._claseQueToma = claseQueTome;
        }

        public Alumno(int id, String nombre, String apellido, String dni, ENacionalidad nacionalidad, Universidad.EClases claseQueTome, EEstadoCuenta estadoCuenta)
            :this(id,nombre,apellido,dni,nacionalidad,claseQueTome)
        {
            this._estadoCuenta = estadoCuenta;
        }
        
        protected override string ParticiparEnClase()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("TOMA CLASE DE "+ this._claseQueToma);

            return builder.ToString();
        }



        public String ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(base.MostrarDatos());
            builder.AppendLine("Estado de cuenta: " + this._estadoCuenta);
            builder.AppendLine(this.ParticiparEnClase());
            return builder.ToString();
        }


        public static bool operator==(Alumno a, Universidad.EClases clase)
        {
            return a._claseQueToma == clase && a._estadoCuenta != EEstadoCuenta.Deudor;            
        }


        public static bool operator!=(Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }



        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

    }


        



}
