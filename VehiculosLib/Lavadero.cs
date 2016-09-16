using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosLib
{
    public class Lavadero
    {
        List<Vehiculo> _vehiculos;

        public List<Vehiculo> Lista
        {
            get
            {
                return this._vehiculos;
            }
        }
        float _precioAuto;
        float _precioCamion;
        float _precioMoto;

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto):this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }

        public double MostrarTotalFacturado()
        {
            float total = 0;
            foreach (Vehiculo v in this._vehiculos)
            {
                if (v is Auto) total += this._precioAuto;
                if (v is Camion) total += this._precioCamion;
                if (v is Moto) total += this._precioMoto;
            }

            return total;
        }
        public double MostrarTotalFacturado(EVehiculos tipo)
        {            
            float precio;
            Predicate<Vehiculo> filter;
            switch(tipo)
            {
                case EVehiculos.Auto:
                    precio = this._precioAuto;
                    filter = delegate(Vehiculo v){
                        return v is Auto;
                    };
                    break;
                case EVehiculos.Camion:
                    precio = this._precioCamion;
                    filter = delegate(Vehiculo v){
                        return v is Camion;
                    };
                    break;
                default:
                    precio = this._precioMoto;
                    filter =  delegate(Vehiculo v){
                        return v is Moto;
                    };
                    break;
            }            

            return precio * this._vehiculos.FindAll(filter).Count;
        }

        public static bool operator ==(Lavadero l, Vehiculo v)
        {
            return l._vehiculos.Exists(delegate(Vehiculo itV) { return itV == v; });            
        }

        public static Lavadero operator +(Lavadero l, Vehiculo v)
        {
            if(l == v )
                l._vehiculos.Add(v);
            return l;
        }

        public static Lavadero operator -(Lavadero l, Vehiculo v)
        {
            l._vehiculos.Remove(v);
            return l;
        }


        public static int OrdenarPorPatente(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente.CompareTo(v2.Patente);
        }

    }
}
