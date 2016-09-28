using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticuloNamespace;

namespace VentaNamespace
{
    class Venta
    {
        private Articulo _articuloVendido;
        private int cantidad;

        public Venta(Articulo art, int cantidad)
        {
            this._articuloVendido = art;
            this.cantidad = cantidad;
        }

        public float RetornarGanancia()
        {
            return this.cantidad * this._articuloVendido.PrecioVenta;
        }


    }
}
