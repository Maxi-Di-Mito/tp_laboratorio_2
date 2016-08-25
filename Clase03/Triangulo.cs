using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Triangulo
    {
        public int baseT;
        public int altura;
        
        private double superficie;

        public Triangulo() { }

        public Triangulo(int b, int h)
        {
            this.baseT = b;
            this.altura = h;
        }

        public static void Dibujar(Triangulo tri)
        {
            double prop = tri.altura / tri.baseT / 2;


            for (int i = tri.altura; i >= 0; i--)
            {
                Console.WriteLine(new String(' ',int.Parse(Math.Floor(prop*i)+"")) +""+new String('*', (i+1) ));
            }
        }


        private void ObtenerDatos()
        {
            this.superficie = this.baseT * this.altura / 2;
        }

        public string Mostrar()
        {
            this.ObtenerDatos();
            return "TRIANGULO\nBase: " + this.baseT + "\nAltura: " + this.altura + "\nSuperficie: " + this.superficie;
        }

    }
}
