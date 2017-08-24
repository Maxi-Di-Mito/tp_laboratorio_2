using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double num)
        {
            string result = "";
            int numEntero = (int)num;
            double numDecimal = num - numEntero;
            char c;

            while ( numEntero >= 2)
            {
                c = numEntero % 2 == 1 ? '1' : '0';
                numEntero /= 2;
                result = c + result;
            }
            c = numEntero == 1 ? '1' : '0';
            result = c + result;

            if(numDecimal > 0)
                result += ',';

            while (numDecimal > 0)
            {
                numDecimal *= 2;
                if (numDecimal >= 1)
                {
                    c = '1';
                    numDecimal -= 1;
                }
                else
                    c= '0';               
                
                result += c;
            }            

           
            
            return result;
        }

        public static double BinarioDecimal(string num) 
        {
            double result = 0;

            string numEntero = num.Split(',')[0];
            string numDecimal = num.Split(',')[1];

            for (int i = 0; i < numEntero.Length; i++)
            {
                double n = numEntero[i] == '1' ? 1 : 0;
                n = n * Math.Pow(2, numEntero.Length - i - 1);
                result += n;
            }
            
            for (int i = 0; i < numDecimal.Length; i++)
            {
                double n = numDecimal[i] == '1' ? 1 : 0;
                n = n * Math.Pow(2,-(i+1));
                result += n;
            }
                        
            return result;
        }


    }
}
