using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio37
{
    class CentralitaException : Exception
    {
        String nombreDeClase;
        String nombreDeMetodo;


        public String NombreClase 
        { 
            get
            {
                return this.nombreDeClase;   
            }
        }

        public String NombreMetodo
        {
            get
            {
                return this.nombreDeMetodo;
            }
        }

        public Exception ExcepcionInterna
        {
            get
            {
                return this.InnerException;
            }
        }


        public CentralitaException(String msg, String clase, String metodo)
            : base(msg)
        {
            this.nombreDeClase = clase;
            this.nombreDeMetodo = metodo;
        }

        public CentralitaException(String msg, String clase, String metodo, Exception inner)
            : base(msg, inner)
        {
            this.nombreDeClase = clase;
            this.nombreDeMetodo = metodo;
        }


    }
}
