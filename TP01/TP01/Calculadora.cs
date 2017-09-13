using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public enum OperacionEnum
    {
        SUMA,
        RESTA,
        MULTIPLICACION,
        DIVISION
    }
    
    class Calculadora
    {
        private static Dictionary<String, OperacionEnum> operaciones;

        public static String[] Operaciones
        {
            get
            {
                return Calculadora.operaciones.Select(delegate (KeyValuePair<String,OperacionEnum> item ) 
                {
                    return item.Key;  
                }).ToArray<String>();
            }            
        }

        static Calculadora()
        {
            Calculadora.operaciones =  new Dictionary<String, OperacionEnum>();
        
            Calculadora.operaciones.Add("+",OperacionEnum.SUMA);
            Calculadora.operaciones.Add("-",OperacionEnum.RESTA);
            Calculadora.operaciones.Add("*",OperacionEnum.MULTIPLICACION);
            Calculadora.operaciones.Add("/",OperacionEnum.DIVISION);
        }

        public static double Operar( Numero op1, Numero op2, String op)
        {
            op = Calculadora.ValidarOperador(op);
            OperacionEnum operacion = Calculadora.operaciones[op];

            switch (operacion)
            {
                case OperacionEnum.SUMA:
                    return op1.GetNumero() + op2.GetNumero();
                case OperacionEnum.RESTA:
                    return op1.GetNumero() - op2.GetNumero();
                case OperacionEnum.MULTIPLICACION:
                    return op1.GetNumero() * op2.GetNumero();
                case OperacionEnum.DIVISION:
                    return op1.GetNumero() / op2.GetNumero();
                default:
                    return 0;
            }
        }

        private static String ValidarOperador(String op)
        {
            if (Calculadora.operaciones.ContainsKey(op))
            {
                return op;
            }
            return "+";
        }

    }
}
