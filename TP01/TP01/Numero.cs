using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0.0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(String numeroString)
        {
            SetNumero(numeroString);
        }


        public double GetNumero()
        {
            return this.numero;
        }

        /// <summary>
        ///  Setea el valor del atributo numero
        /// </summary>
        /// <param name="numeroString"></param>
        private void SetNumero(String numeroString)
        {
            this.numero = Numero.ValidarNumero(numeroString);
        }

        /// <summary>
        ///  Valida que se trate de un double válido, caso contrario retorna 0
        /// </summary>
        /// <param name="numeroString"> numero a parsear</param>
        /// <returns></returns>
        private static double ValidarNumero(String numeroString)
        {
            double numeroDouble;

            Double.TryParse(numeroString, out numeroDouble);
            
            return numeroDouble;
        }




    }
}
