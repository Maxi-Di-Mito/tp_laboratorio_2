using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class ClaseInicial
    {

        public ClaseInicial()
        {
            try
            {
                ClaseInicial.DivisorPorCero();
            }
            catch (DivideByZeroException ceroException)
            {
                throw ceroException;
            }
        }


        static void DivisorPorCero()
        {
            int cero = 0;
            int no = 3 / cero;
        }

    }
}
