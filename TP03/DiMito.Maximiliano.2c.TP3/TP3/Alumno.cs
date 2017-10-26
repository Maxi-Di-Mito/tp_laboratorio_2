using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Alumno: Universitario
    {
        private EClases _claseQueToma;
        private EEstadoCuenta _estadoCuenta;

        public Alumno(){}

        public Alumno(int id, String nombre, String apellido, String dni, ENacionalidad nacionalidad, EClases claseQueTome)
        {

        }
        
        protected override string ParticiparEnClase()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("TOMA CLASE DE");

            return builder.ToString();
        }



        public String ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(base.MostrarDatos());
            builder.AppendLine(this.ParticiparEnClase());
            return builder.ToString();
        }


        public static bool operator==(Alumno a, EClases clase)
        {
            return a._claseQueToma == clase && a._estadoCuenta != EEstadoCuenta.Deudor;            
        }


        public static bool operator!=(Alumno a, EClases clase)
        {
            return !(a == clase);
        }



        enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

    }



    public enum EClases
    {
        Programacion,
        Laboratorio,
        Legislacion,
        SPD
    }



}
