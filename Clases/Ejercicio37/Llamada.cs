﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }


    abstract class Llamada
    {
        protected float _duracion;
        protected String _nroDestino;
        protected String _nroOrigen;

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }
        public String NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }
        public String NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        virtual public float CostoLlamada 
        {
            get 
            {
                return 0;
            }
        }


        public Llamada(float duracion, String nroDestino, String nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }

        public virtual String Mostrar()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Duracion: " + this._duracion);
            builder.AppendLine("NroOrigen: " + this._nroOrigen);
            builder.AppendLine("NroDestino: " + this._nroDestino);
            return builder.ToString();
        }

        public int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            return (int)Math.Ceiling(l1._duracion - l2._duracion);
        }


        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && l1._nroOrigen == l2._nroOrigen && l1._nroDestino == l2._nroDestino;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }


    }
}
