using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class Centralita
    {
        private List<Llamada> listadeLlamadas;
        private String razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listadeLlamadas;
            }
        }

        public Centralita()
        {
            this.listadeLlamadas = new List<Llamada>();
        }

        public Centralita(String nombreEmpresa): this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;

            foreach (Llamada l in this.listadeLlamadas)
            {
                if (tipo == TipoLlamada.Local || tipo == TipoLlamada.Todas)
                {
                    if (l is Local)
                    {                        
                        ganancia += l.CostoLlamada;
                    }                    
                }
                if (tipo == TipoLlamada.Provincial || tipo == TipoLlamada.Todas)
                {
                    if (l is Provincial)
                    {                        
                        ganancia += l.CostoLlamada;
                    }  
                }
            }
            return ganancia;
        }

        public String Mostrar()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(this.razonSocial);
            foreach(Llamada l in this.listadeLlamadas)
            {
                builder.AppendLine(l.Mostrar());
            }

            return builder.ToString();       
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listadeLlamadas.Add(nuevaLlamada);
        }
        


        public void OrdenarLlamadas()
        {

        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            return c.listadeLlamadas.Contains(l);
        }


        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada l)
        {
            if (!(c == l))
                c.AgregarLlamada(l);

            return c;
        }

    }
}
