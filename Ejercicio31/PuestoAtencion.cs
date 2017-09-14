using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ejercicio31
{
    class PuestoAtencion
    {
        private static int numeroActual;
        private PuestoEnum puesto;

        public static int NumeroActual
        {
            get
            {
                return ++PuestoAtencion.numeroActual;
            }
        }


        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(PuestoEnum puesto)
        {
            this.puesto = puesto;
        }


        public bool Atender(Cliente cliente)
        {
            Random r = new Random();
            Thread.Sleep(r.Next(100, 300));
            return true;
        }


    }

    enum PuestoEnum
    {
        Caja1,
        Caja2
    }



}
