using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloNamespace
{
    class Articulo
    {
        #region ATTRs
        private int _codigo;
        private string _nombre;
        private float _precioCosto;
        private float _precioVenta;
        private int _stock;
        #endregion

        #region properties
        public string NombreYCodigo
        {
            get
            {
                return this._nombre + " - " + this._codigo;
            }
        }

        public float PrecioCosto
        {
            set
            {
                this._precioCosto = value;
                this._precioVenta = this._precioCosto * (float)1.3;
            }
        }

        public float PrecioVenta 
        {
            get
            {
                return this._precioVenta;
            }
        }

        public int Stock
        {
            set
            {
                this._stock = value;
            }
        }

        #endregion

        #region Constructor
        public Articulo(int cod, string nom, float pCosto, int cant)
        {
            this._codigo = cod;
            this._nombre = nom;
            this.PrecioCosto = pCosto;            
            this._stock = cant;
        }
        #endregion

        #region Metodos y Sobrecargas

        public bool HayStock(int cantidad)
        {
            return this._stock >= cantidad;
        }

        public static bool operator ==(Articulo a1, Articulo a2)
        {
            if (Object.Equals(a1, null) && Object.Equals(a2, null))
            {
                return true;
            }
            if (Object.Equals(a1, null) || Object.Equals(a2, null))
            {
                return false;
            }
                
            return (a1._nombre == a2._nombre && a1._codigo == a2._codigo);
        }

        public static bool operator !=(Articulo a1, Articulo a2)
        {
            return !(a1 == a2);
        }

        public static int operator +(Articulo a1, Articulo a2)
        {
            return a1._stock + a2._stock;
        }

        public static int operator -(Articulo a1, int cantidad)
        {
            return a1._stock - cantidad;
        }


        #endregion







    }
}
