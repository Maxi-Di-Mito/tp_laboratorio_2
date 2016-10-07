using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local : Llamada
    {
        protected float _costo;

        public float CostoLlamada
        {
            get
            {
                return this._costo;
            }
        }

        public Local(Llamada l, float costo)
            : this(l.NroOrigen, l.Duracion, l.NroDestino, costo) { }
        

        public Local(string origen, float duracion, string destino, float costo)
            : base(origen, destino, duracion)
        {
            this._costo = costo;
        }


        private float CalcularCosto()
        {
            return base._duracion * this._costo;
        }

        override public void Mostrar()
        {
            StringBuilder b = new StringBuilder();
            b.Append("\tCOSTO LLAMADA: ");
            b.Append(this._costo);
            base.Mostrar();
            Console.WriteLine(b);
        }




    }
}
