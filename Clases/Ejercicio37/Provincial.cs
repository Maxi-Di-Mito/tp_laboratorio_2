using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    


    class Provincial:Llamada
    {
        private Franja _franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada l)
            :base(l.Duracion,l.NroDestino,l.NroOrigen)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(String origen, Franja miFranja, float duracion, String destino)
            :base(duracion,destino,origen)
        {
            this._franjaHoraria = miFranja;
        }

        protected String Mostrar()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(base.Mostrar());
            builder.AppendLine("Franja: " + this._franjaHoraria);
            builder.AppendLine("Costo: " + this.CostoLlamada);
            return builder.ToString();
        }

        public override string ToString()
        {
 	        return this.Mostrar();
        }

        private float CalcularCosto()
        {
            float result = 0;
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    result = base._duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    result = base._duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    result = base._duracion * 0.66f;
                    break;
            }
            return result;
        }


        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
              



        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
