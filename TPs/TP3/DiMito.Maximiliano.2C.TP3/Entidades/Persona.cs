using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region Atributos y Props
        private string _apellido;

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = ValidarNombreApellido(value); }
        }

        private int _dni;

        public int DNI
        {
            get { return this._dni; }
            set { this._dni = ValidadDni(this._nacionalidad,value); }
        }

        private ENacionalidad _nacionalidad;

        public ENacionalidad Nacionalidad
        {
            get { return this._nacionalidad; }
            set { this._nacionalidad = ValidarNombreApellido(value); }
        }

        private string _nombre;

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string StringToDNI 
        { 
            set
            {
                this._dni = int.Parse(value);
            }
        }
        #endregion

        #region Constructores
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this._dni = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        public override string ToString()
        {
            return base.ToString();
        }

        private int ValidadDni(ENacionalidad nacionalidad, int dato)
        {
            if((nacionalidad == ENacionalidad.Argentino && dato > 0 && dato < 90000000) || nacionalidad == ENacionalidad.Extranjero)
                return dato;
            else
                throw new DniInvalidoException();
        }

        private int ValidadDni(ENacionalidad nacionalidad, string dato)
        {
            return ValidadDni(nacionalidad, int.Parse(dato));
        }

        private string ValidarNombreApellido(string dato)
        {
            Regex regex = new Regex("[a-zA-Z]+");
            if (regex.Match(dato).Success)
            {
                return dato;
            }
            return "";
        }

    }

    public enum ENacionalidad
    {
        Argentino, Extranjero
    }

}
