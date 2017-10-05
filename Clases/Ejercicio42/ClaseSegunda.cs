using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class ClaseSegunda
    {


        public void InitCaos()
        {
            ClaseSegunda c;
            try
            {
                c = new ClaseSegunda();
            }
            catch (UnaException ex)
            {
                throw new MiException("Rompio el metodo de instancia",ex);
            }
        }


        public ClaseSegunda(String alPedo)
        {

        }


        private ClaseSegunda()
        {
            try
            {
                new ClaseInicial();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaException("Catch de CLASE_SEGUNDA",ex);
            }
        }
    }
}
