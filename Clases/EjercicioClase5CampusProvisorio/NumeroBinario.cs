using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio13;

namespace EjercicioClase5CampusProvisorio
{
    public class NumeroBinario
    {

        private String valor;

        private NumeroBinario(String n)
        {
            this.valor = n;
        }


        public static String operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            double a = Conversor.BinarioDecimal(nb.valor);
            double b = (double)nd;
            double result = a + b;
            
            return Conversor.DecimalBinario(result);
        }

        public static String operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            double a = Conversor.BinarioDecimal(nb.valor);
            double b = (double)nd;
            double result = a - b;

            return Conversor.DecimalBinario(result);
        }

        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            double a = Conversor.BinarioDecimal(nb.valor);
            double b = (double)nd;
            return a == b;
        }

        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb == nd);
        }


        public static implicit operator NumeroBinario(String n)
        {
            return new NumeroBinario(n);
        }

        public static explicit operator String(NumeroBinario n)
        {
            return n.valor;
        }
    }
}
