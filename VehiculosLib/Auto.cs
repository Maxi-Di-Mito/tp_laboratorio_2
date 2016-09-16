using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosLib
{
    public class Auto:Vehiculo
    {
        int _cantidadAsientos;

        public Auto(int cantRuedas, string pat, byte ruedas, EMarcas m):base(pat,ruedas,m)
        {
            this._cantidadAsientos = cantRuedas;
        }

        public string MostrarAuto()
        {
            return base.Mostrar() + " CantidadDeAsientos: " + this._cantidadAsientos;
        }
    }
}
