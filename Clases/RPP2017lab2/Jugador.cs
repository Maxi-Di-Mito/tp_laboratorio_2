using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP2017lab2
{
    public class Jugador:Persona
    {
        private bool _esCapitan;
        private int _numero;

        public bool EsCapitan
        {
            get
            {
                return this._esCapitan;
            }
            set
            {

            }
        }

        public int Numero 
        {
            get
            {
                return this._numero;
            }
            set
            {

            }
        }

        public Jugador(String nombre, String apellido)
            :this(nombre,apellido,0,false)
        {            
        }

        public Jugador(String nombre, String apellido, int numero, bool capitan)
            : base(nombre, apellido)
        {
            this._esCapitan = capitan;
            this._numero = numero;
        }

        
        
        protected override string FichaTecnica()
        {
            String nombre = base.NombreCompleto();
            String capitan = this._esCapitan ? "capitan del equipo," : "";
            String camiseta = String.Format("camiseta numero {0}", this._numero);
            return String.Format("{0}, {1} {2}", nombre, capitan, camiseta);            
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool mismoNombre = j1.Nombre == j2.Nombre;
            bool mismoApellido = j1.Apellido == j2.Apellido;
            bool mismoNumero = j1._numero == j2._numero;

            return mismoNombre && mismoApellido && mismoNumero;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int(Jugador jugador)
        {
            return jugador._numero;
        }

        public override bool Equals(object obj)
        {
            return (obj is Jugador) && ((Jugador)obj == this);
            
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }


    }
}
