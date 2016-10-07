using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }


        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        virtual public void Mostrar()
        {
            StringBuilder b = new StringBuilder();
            b.Append("DURACION: ");
            b.Append(this._duracion);
            b.Append(" - ORIGEN: ");
            b.Append(this._nroOrigen);
            b.Append(" - DESTINO: ");
            b.Append(this._nroDestino);
            Console.WriteLine(b);
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            float resta = uno._duracion - dos._duracion;
            return resta > 0 ? 1 : (resta == 0 ? 0 : -1);
        }


    }
}
