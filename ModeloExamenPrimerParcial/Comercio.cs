using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticuloNamespace;
using VentaNamespace;

namespace ComercioNamespace
{
    class Comercio
    {
        private string _dueño;
        private List<Articulo> _misArticulos;
        private List<Venta> _misVentas;

        public Comercio(string dueño)
        {
            this._dueño = dueño;
            this._misArticulos = new List<Articulo>();
            this._misVentas = new List<Venta>();
        }

        public void ComprarArticulo(Articulo articuloComprado)
        {
            Articulo articuloBuscado = null;
            articuloBuscado = this._misArticulos.Find(delegate(Articulo a){ return a == articuloComprado;});
            if(articuloBuscado != null)
            {
                articuloBuscado.Stock = articuloBuscado + articuloComprado;
            }else
            {
                this._misArticulos.Add(articuloComprado);
            }
        }

        public static void MostrarArticulos(Comercio comercioAMostrar)
        {
            Console.WriteLine("ARTICULOS:");
            comercioAMostrar._misArticulos.ForEach(
                delegate(Articulo a) { Console.WriteLine(a.NombreYCodigo); }
            );
        }

        public static void MostrarGanancia(Comercio comercioParaResumen)
        {
            float totalGanancia = 0;            
            totalGanancia = comercioParaResumen._misVentas.Sum(delegate(Venta v) { return v.RetornarGanancia(); });
            Console.WriteLine("GANANCIA: $ "+ totalGanancia);
        }

        public void VenderArticulo(Articulo articuloSolicitado, int cantidad)
        {
            Articulo articuloBuscado = null;
            articuloBuscado = this._misArticulos.Find(delegate(Articulo a) { return a == articuloSolicitado; });
            if( articuloBuscado != null && articuloBuscado.HayStock(cantidad))
            {
                articuloBuscado.Stock = articuloBuscado - cantidad;
                this._misVentas.Add(new Venta(articuloBuscado,cantidad));
            }else
            {
                if(articuloBuscado != null)
                    Console.WriteLine("El  articulo no tiene stock para su venta : \n"+articuloSolicitado.NombreYCodigo);
                else
                    Console.WriteLine("El  articulo existe en nuestro comercio : \n" + articuloSolicitado.NombreYCodigo);
            }
        }
    }
}
