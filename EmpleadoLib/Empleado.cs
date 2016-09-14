using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoLib
{
    public class Empleado
    {
        string _nombre;
        string _apellido;
        string _legajo;
        EPuestoJerarquico _puesto;
        string _salario;

        public Empleado(string n, string a, string l, string p, string s)
        {
            this._nombre = n;
            this._apellido = a;
            this._legajo = l;
            this._puesto = p;
            this._salario = s;
        }


        public string Mostrar()
        {
            return "NOMBRE: " + this._nombre + "\nAPELLIDO: " + this._apellido + "\nLEGAJO: " + this._legajo + "\nPUESTO: " + this._puesto + "\nSALARIO: " + this._salario + "\n";
        }


        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return e1._legajo == e2._legajo;
        }


        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

    }
}
