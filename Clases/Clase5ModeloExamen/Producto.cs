using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5ModeloExamen
{
    class Producto
    {
        private String _marca;
        private float _precio;
        private String _codigoBarra;

        public Producto()
        {

        }


        public String GetMarca(){
            return this._marca;
        }

        public float GetPrecio()
        {
            return this._precio;
        }

        public static String MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca: " + p._marca);
            sb.AppendLine("Precio: " + p._precio);
            sb.AppendLine("Codigo: " + p._codigoBarra);
            
            return sb.ToString();
        }


        public static bool operator ==(Producto a, Producto b)
        {
            return a._marca == b._marca && a._codigoBarra == b._codigoBarra;
        }

        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }

        public static bool operator ==(Producto prod, String marca)
        {
            return prod._marca == marca;
        }
        public static bool operator !=(Producto prod, String marca)
        {
            return !(prod == marca);
        }


        public static explicit operator String(Producto prod)
        {
            return prod._codigoBarra;
        }



    }
}
