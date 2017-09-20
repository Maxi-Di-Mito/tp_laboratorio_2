using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private String nombre;

        public Cliente Cliente 
        { 
            get
            {
                return this.clientes.Dequeue();   
            }
            set
            {
                bool result = this + value;
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoEnum.Caja1);
        }

        public Negocio(String nombre)
            : this()
        {
            this.nombre = nombre;
        }


        public static bool operator +(Negocio n, Cliente c)
        {
            if (n == c)
                return false;
            else
            {
                n.clientes.Enqueue(c);
                return true;
            }
        }


        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cli in n.clientes)
            {
                if (cli == c)
                    return true;
            }            
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }


        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }


    }
}
