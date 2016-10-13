using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    public class ColectoraDeNumeros
    {
        protected List<Numero> _numeros;

        public ETipoNumero TipoNumero
        {
            get;
            set;
        }

        public int SumaDeNumeros
        {
            get
            {
                return (int)ObtenerResultadoColectoraDeNumeros(ETipoResultado.Suma);
            }
        }
                
        public int RestaDeNumeros
        {
            get
            {
                return (int)ObtenerResultadoColectoraDeNumeros(ETipoResultado.Resta);
            }
        }

        public int MultiplicacionDeNumeros
        {
            get
            {
                return (int)ObtenerResultadoColectoraDeNumeros(ETipoResultado.Multiplicacion);
            }
        }

        public double DivisionDeNumeros
        {
            get
            {
                return ObtenerResultadoColectoraDeNumeros(ETipoResultado.Division);
            }
        }

        private ColectoraDeNumeros()
        {
            this._numeros = new List<Numero>();
        }

        public ColectoraDeNumeros(ETipoNumero tipo):this()
        {
            this.TipoNumero = tipo;
        }

        public static ColectoraDeNumeros operator +(ColectoraDeNumeros col, Numero n)
        {            
            col._numeros.Add(n);
            return col;
        }

        public static ColectoraDeNumeros operator -(ColectoraDeNumeros col, Numero n)
        {
            col._numeros.Remove(n);
            return col;
        }


        public override string ToString()
        {
            string ret = "TIPO: "+this.TipoNumero+"\n";
            this._numeros.ForEach(delegate(Numero n){ ret += " "+n.numero;});
            return ret;
        }

        private int SumarNumeros()
        {
            int rta = 0;
            for (int i = 1; i < this._numeros.Count; i++)
            {
                rta += _numeros[0] + _numeros[i];
            }
            return rta;
        }

        private int RestarNumeros()
        {
            int rta = 0;
            for (int i = 1; i < this._numeros.Count; i++)
            {
                rta -= _numeros[0] - _numeros[i];
            }
            return rta;
        }

        private int MultiplicarNumeros()
        {
            int rta = 1;
            for (int i = 1; i< this._numeros.Count;i++)
            {
                rta *= _numeros[0] * _numeros[i]; 
            }
            return rta;
        }

        private double DividirNumeros()
        {
            double rta = 0;
            for (int i = 1; i < this._numeros.Count; i++)
            {
                rta /= _numeros[0] / _numeros[i];
            }
            return rta;
        }

        protected double ObtenerResultadoColectoraDeNumeros(ETipoResultado tipoResultado)
        {
            switch (tipoResultado)
            {
                case ETipoResultado.Suma:
                    return SumarNumeros();

                case ETipoResultado.Resta:
                    return RestarNumeros();

                case ETipoResultado.Multiplicacion:
                    return MultiplicarNumeros();

                default:
                    return DividirNumeros();
            }

        }


    }
}
