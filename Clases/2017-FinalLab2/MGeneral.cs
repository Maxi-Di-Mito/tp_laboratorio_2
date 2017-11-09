using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2017_FinalLab2
{
    public class MGeneral:Medico, IMedico
    {
        protected override void Atender()
        {
            int tiempo = Medico.tiempoAleatorio.Next(1500, 2200);
            Thread.Sleep(tiempo);
            base.FinalizarAtencion();
        }



        public void IniciarAtencion(Paciente p)
        {
            this.AtenderA = p;
            Thread hilo = new Thread(this.Atender);
            hilo.Start();
        }


        public MGeneral(String nombre, String apellido)
            : base(nombre, apellido)
        {
        }
    }
}
