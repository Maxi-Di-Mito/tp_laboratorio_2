using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TP3
{
    abstract class Persona
    {

        private String _nombre;
        private String _apellido;
        private ENacionalidad _nacionalidad;
        private int _dni;


        public String Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = this.ValidarNombreApellido(value);
            }
        }

        public String Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = this.ValidarNombreApellido(value);
            }
        }
        
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this._nacionalidad;
            }
            set
            {
                this._nacionalidad = value;
            }
        }

        public int DNI
        {
            get
            {
                return this._dni;
            }
            set
            {
                this._dni = this.ValidarDni(this._nacionalidad, value);
            }
        }

        public String StringToDNI
        {
            set
            {
                this._dni = this.ValidarDni(this._nacionalidad, value);
            }
        }


        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino)
            {
                if (dato >= 1 && dato <= 89999999)
                    return dato;
                else
                    throw new DniInvalidoException("El dni no es valido para un argentino");
            }
            else
            {
                if (dato > 89999999 && dato <= 99999999)
                    return dato;
                else
                    throw new DniInvalidoException("El dni no es valido para un extranjero");
            }            
        }

        private int ValidarDni(ENacionalidad nacionalidad, String dato)
        {
            int result;
            if (int.TryParse(dato, out result))
            {
                if (nacionalidad == ENacionalidad.Argentino)
                {
                    return this.ValidarDni(nacionalidad,result);
                }
            }
            else
            {
                throw new DniInvalidoException("El dni no es valido");
            }
            
        }

        
        private String ValidarNombreApellido(String dato)
        {
            if ((new Regex(@"[a-zA-z ]+", RegexOptions.ECMAScript)).Match(dato).Length > 0)
                return dato;
            else
                return null;
        }


        public Persona()
        { }

        public Persona(String nombre, String apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this._nacionalidad = nacionalidad;
        }

        public Persona(String nombre, String apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre,apellido,nacionalidad)                
        {
            this.DNI = dni;
        }





        public String ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Apellido: " + this._apellido);
            builder.AppendLine("Nombre: " + this._nombre);
            builder.AppendLine("DNI: " + this._dni);
            builder.AppendLine("Nacionalidad: " + this._nacionalidad);

            return builder.ToString();
        }




    }


    public enum ENacionalidad
    {
        Argentino,
        Extranjero
    }

}
