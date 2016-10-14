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
        private string _ruta;

        public string RutaDeArchivo
        {
            get
            {
                return this._ruta;
            }
            set
            {
                this._ruta = value;
            }
        }

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
              

        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            b.AppendLine("RAZON SOCIAL: " + this._razonSocial);
            b.AppendLine("GANANCIA TOTAL: " + this.GananciaTotal);
            b.AppendLine("GANANCIA POR LOCALES: " + this.GananciaPorLocal);
            b.AppendLine("GANANCIA POR PROVINCIALES: " + this.GananciaPorProvincial);
            foreach (Llamada l in this._listaDeLlamadas)
            {
                b.AppendLine(l.ToString());
            }
            return b.ToString();
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


        private void AgregarLlamada(Llamada l)
        {
            this._listaDeLlamadas.Add(l);
        }


        private void GuardarEnArchivo(Llamada llamada, bool agrego)
        {
            if (agrego)
            {
                // appendeo
            }
            else
            {
                //reescribo
            }

        }



        public static bool operator ==(Centralita c, Llamada llamada)
        {
            return c._listaDeLlamadas.Exists(delegate(Llamada l) { return l == llamada; });
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada l)
        {
            if (c != l)
                c.AgregarLlamada(l);
            else
                throw new CentralitaException("La llamada ya se encuentra cargada", "Centralita", "+");
            return c;
        }


    }
}
