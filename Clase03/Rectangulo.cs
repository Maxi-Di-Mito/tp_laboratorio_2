using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Rectangulo
    {
        private int ladoUno;
        private int ladoDos;

        private double perimetro;
        private double superficie;
        
        public Rectangulo() { }

        public Rectangulo(int l1, int l2)
        {
            this.ladoUno = l1;
            this.ladoDos = l2;
        }
        
        public static void Dibujar(Rectangulo r)
        {
            for (int i = 0; i < r.ladoUno; i++)
            {
                Console.WriteLine( new String('*',r.ladoDos));
            }
        }


        private void ObtenerDatos()
        {
            this.perimetro = 2 * this.ladoDos + 2 * this.ladoUno;
            this.superficie = this.ladoUno * this.ladoDos;
        }

        public string Mostrar()
        {
            this.ObtenerDatos();
            return "RECTANGULO:\nLadoUno: "+this.ladoUno+"\nLadoDos: "+this.ladoDos+"\nPerimetro: "+this.perimetro+"\nSuperficie: "+this.superficie;
        }

    }
}
