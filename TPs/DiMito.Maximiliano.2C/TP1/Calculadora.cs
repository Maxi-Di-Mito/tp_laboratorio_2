using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Calculadora
    {
        public static string[] operadores = {"+","-","*","/"};

        public static double Operar(Numero n1, Numero n2, string operador)
        {
            Numero result = new Numero();
            operador = Calculadora.ValidarOperador(operador);
            switch (operador)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
            }

            return result.GetNumero();
        }

        public static string ValidarOperador(string oper)
        {
            if(oper.Length > 1 || oper.Length < 1)
                return "+";

            if (Calculadora.operadores.Contains(oper))
                return oper;
            else
                return "+";
        }

    }
}
