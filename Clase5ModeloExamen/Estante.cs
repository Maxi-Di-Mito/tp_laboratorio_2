using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5ModeloExamen
{
    class Estante
    {
        private int _max;
        private int _ubicacion;
        private Producto[] _productos;


        private Estante(int cant)
        {
            this._productos = new Producto[cant];
        }

        public Estante(int cant, int ubicacion)
            : this(cant)
        {
            this._ubicacion = ubicacion;
            this._max = cant;
        }

        public Producto[] GetProductos()
        {
            return this._productos;
        }

        public static String MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ubicacion: " + e._ubicacion);
            sb.AppendLine("Capacidad Maxima: " + e._max);

            foreach(Producto p in e._productos) {
                sb.AppendLine("Producto: " + Producto.MostrarProducto(p));
            }
            return sb.ToString();
        }

        public static bool operator ==(Estante estante, Producto prod)
        {
            foreach (Producto p in estante._productos)
            {
                if (p == prod)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Estante estante, Producto prod)
        {
            return !(estante == prod);
        }

        public static bool operator +(Estante estante, Producto prod)
        {
            return (estante._productos.Length < estante._max) && (estante != prod);///TODO QUE ONDA esto?
        }

        public static Estante operator -(Estante estante, Producto prod)
        {
            Estante nuevoEstante = new Estante(estante._max, estante._ubicacion);
            
            foreach (Producto p in estante._productos)
            {
                if (p != prod)
                {
                    nuevoEstante._pro//TODO hacer metodo y consultar el +;
                }
            }

            return nuevoEstante;
        }

    }
}
