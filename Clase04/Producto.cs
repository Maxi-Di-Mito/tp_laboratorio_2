using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Producto
    {        
        private string codBarra;
        private double precio;
        private string nombre;

        #region Constructores

        /// <summary>
        ///     Genera un nuevo producto
        /// </summary>
        /// <param name="precio">Precio de venta del producto</param>
        /// <param name="codigoDeBarras">Codigo de barras del producto</param>
        /// <param name="nombre">Nombre del producto</param>
        public Producto(double precio, string codigoDeBarras , string nombre)
        {
            this.precio = precio;
            this.codBarra = codigoDeBarras;
            this.nombre = nombre;
        }
        /// <summary>
        ///     Genera un nuevo objeto Producto
        /// </summary>
        /// <param name="precio">Precio de venta del producto</param>
        /// <param name="codigoDeBarras">Codigo de barras del producto</param>
        public Producto(double precio, string codigoDeBarras):this(precio)//reutilizacion e constructor
        {   
            this.codBarra = codigoDeBarras;            
        }
        /// <summary>
        ///     Genera un nuevo objeto Producto
        /// </summary>
        /// <param name="precio">Precio de venta del producto</param>
        public Producto(double precio):this()
        {            
            this.precio = precio;            
        }
        /// <summary>
        ///     Genera un nuevo objeto Producto
        /// </summary>
        public Producto()
        {
            this.precio = 0.0;
            this.codBarra = "sinCodigo";
            this.nombre = "sinNombre";
        }
        

        #endregion

        /// <summary>
        ///     Imprime la representacion en string del objeto Producto
        /// </summary>
        public void Mostrar()
        {
            Console.WriteLine("CODIGO: "+this.codBarra+"\nNOMBRE: "+this.nombre+"\nPRECIO: "+this.precio);
        }

    }
}
