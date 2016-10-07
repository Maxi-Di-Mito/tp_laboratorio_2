using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }
        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciaTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public Centralita() 
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this._razonSocial = nombreEmpresa;

        }

        public void Mostrar()
        {
            Console.WriteLine("RAZON SOCIAL: " + this._razonSocial);
            Console.WriteLine("GANANCIA TOTAL: " + this.GananciaTotal);
            Console.WriteLine("GANANCIA POR LOCALES: " + this.GananciaPorLocal);
            Console.WriteLine("GANANCIA POR PROVINCIALES: " + this.GananciaPorProvincial);
            foreach (Llamada l   in this._listaDeLlamadas)
            {
                l.Mostrar();
            }
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
                

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0f;

            if (tipo == TipoLlamada.Todas || tipo == TipoLlamada.Local)
            {
                ganancia += this._listaDeLlamadas
                                    .FindAll(delegate(Llamada l) { return l is Local; })
                                    .Sum(delegate(Llamada l) { return ((Local)l).CostoLlamada; });
            }
            if (tipo == TipoLlamada.Todas || tipo == TipoLlamada.Provincial)
            {
                ganancia += this._listaDeLlamadas
                                    .FindAll(delegate(Llamada l) { return l is Provincial; })
                                    .Sum(delegate(Llamada l) { return ((Provincial)l).CostoLlamada; });
            }

            return ganancia;
        }





    }
}
