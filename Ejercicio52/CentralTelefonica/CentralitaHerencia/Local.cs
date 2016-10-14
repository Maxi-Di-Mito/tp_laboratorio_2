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

        
        
        override public float CostoLlamada
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

        override protected string Mostrar()
        {
            StringBuilder b = new StringBuilder();
            b.Append(base.Mostrar());
            b.Append("\tCOSTO LLAMADA: ");
            b.Append(this._costo);
            return b.ToString();            
        }

        override public bool  Equals(Object obj)
        {
            return obj is Local;
        }

        override public string ToString()
        {
            return this.Mostrar();
        }

    }
}
