using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP2017lab2
{
    public abstract class Persona
    {
        private String _apellido;
        private String _nombre;

        public String Apellido
        {
            get
            {
                return this._apellido;
            }
        }

        public String Nombre
        {
            get
            {
                return this._nombre;
            }            
        }


        public Persona(String nombre, String apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }


        protected virtual String NombreCompleto()
        {
           return String.Format("{0} {1}", this._nombre, this._apellido);
        }

        protected abstract String FichaTecnica();


       

    }
}
