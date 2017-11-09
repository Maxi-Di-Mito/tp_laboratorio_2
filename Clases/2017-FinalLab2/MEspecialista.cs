using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2017_FinalLab2
{
    public class MEspecialista:Medico,IMedico
    {
        private Especialidad especialidad;



        public MEspecialista(String nombre, String apellido, Especialidad e)
            :base(nombre,apellido)
        {
            this.especialidad = e;
        }



        protected override void Atender()
        {

            int tiempo = Medico.tiempoAleatorio.Next(5000, 10000);
            Thread.Sleep(tiempo);
            base.FinalizarAtencion();
        }



        public void IniciarAtencion(Paciente p)
        {
            this.AtenderA = p;
            Thread hilo = new Thread(this.Atender);
            hilo.Start();
        }





        public enum Especialidad
        {
            Traumatologo,
            Odontologo
        }

    }
}
