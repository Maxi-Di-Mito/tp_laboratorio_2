using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class Local:Llamada
    {
        private float _costo;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }


        public Local(Llamada l, float costo)
            :base(l.Duracion,l.NroDestino,l.NroOrigen)
        {
            this._costo = costo;
        }

        public Local(String origen, float duracion, String destino, float costo)
            : base(duracion, destino, origen)
        {
            this._costo = costo;
        }

        private float CalcularCosto()
        {
            return base._duracion * this._costo;
        }

        protected override String Mostrar()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(base.Mostrar());
            builder.AppendLine("Costo: " + this.CostoLlamada);
            return builder.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }


        public override string ToString()
        {
            return this.Mostrar();
        }
        


    }
}
