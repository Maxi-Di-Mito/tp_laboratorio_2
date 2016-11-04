using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class PersonaGimnasio:Persona
    {
        private int _identificador;

        public PersonaGimnasio(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this._identificador = id;
        }


        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("nombre: " + base.Nombre);
            sb.Append("apellido: " + base.Apellido);
            sb.Append("dni: " + base.DNI);
            sb.Append("nacionalidad: " + base.Nacionalidad);
            return sb.ToString();
        }

        //protected abstract ParticiparEnClase

        public override bool Equals(object obj)
        {
            if (obj is PersonaGimnasio)
            {
                PersonaGimnasio o = (PersonaGimnasio)obj;
                return (o.DNI == this.DNI) || (o._identificador == this._identificador);
            }
            return false;
        }

    }
}
