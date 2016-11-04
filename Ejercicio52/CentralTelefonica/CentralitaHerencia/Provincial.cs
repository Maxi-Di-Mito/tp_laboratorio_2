﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial(Franja mFranja, Llamada l)
            : this(l.NroOrigen, mFranja, l.Duracion, l.NroDestino) { }


        public Provincial(string origen,Franja mFranja, float duracion, string destino)
            : base(origen, destino, duracion)
        {
            this._franjaHoraria = mFranja;
        }

        private float CalcularCosto()
        {
            float costo = 0f;
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = 0.99f;
                    break;
                case Franja.Franja_2:
                    costo = 1.25f;
                    break;
                case Franja.Franja_3:
                    costo = 0.66f;
                    break;
            }
            return costo * base._duracion;
        }

        override protected string Mostrar()
        {
            StringBuilder b = new StringBuilder();
            b.Append(base.Mostrar());
            b.Append("\tCOSTO LLAMADA: ");
            b.Append(this.CostoLlamada);
            b.Append(" - FRANJAHORARIA: ");
            b.Append(this._franjaHoraria);
            return b.ToString();
        }

        public override bool Equals(Object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}