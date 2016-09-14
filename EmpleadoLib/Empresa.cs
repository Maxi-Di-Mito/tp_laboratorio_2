using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoLib
{
    class Empresa
    {
        List<Empleado> _nominaEmpleados;

        private Empresa()
        {
            this._nominaEmpleados = new List<Empleado>();
        }

        public Empresa(string razon, string direccion, string ganancias)
            : this()
        {
            this._razonSocial = razon;
            this._direccion = direccion;
            this._ganancias = ganancias;
        }


        private string _razonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        private string _direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private string _ganancias
        {
            get { return _ganancias; }
            set { _ganancias = value; }
        }

        public static Empresa operator +(Empresa empresa, Empleado empleado)
        {
            if (!empresa._nominaEmpleados.Contains(empleado))
            {
                empresa._nominaEmpleados.Add(empleado);
            }
            return empresa;
        }
    }
}
