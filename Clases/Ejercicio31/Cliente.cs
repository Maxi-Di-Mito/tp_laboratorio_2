using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Cliente
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int numero;

        public int Numero
        {
            get { return numero; }            
        }


        private Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, String nombre)
            : this(numero)
        {
            this.nombre = nombre;
        }


        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }





    }
}
