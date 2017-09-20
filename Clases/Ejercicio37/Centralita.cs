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
                        ganancia += l.CostoHeredado();
                    }                    
                }
                if (tipo == TipoLlamada.Provincial || tipo == TipoLlamada.Todas)
                {
                    if (l is Provincial)
                    {                        
                        ganancia += l.CostoHeredado();
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


        public void OrdenarLlamadas()
        {

        }





    }
}
