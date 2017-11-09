using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_FinalLab2
{

    public delegate void FinAtencionPaciente(Paciente p, Medico m);


    public abstract class Medico:Persona
    {
        protected Paciente pacienteActual;
        protected static Random tiempoAleatorio;


        public Paciente AtenderA 
        {
            set
            {
                this.pacienteActual = value;
            }                
        }

        public virtual String EstaAtendiendoA
        {
            get
            {
                return this.pacienteActual.ToString();
            }
        }

        static Medico()
        {
            Medico.tiempoAleatorio = new Random();
        }

        public Medico(String nombre, String apellido)
            :base(nombre,apellido)
        {

        }


        protected abstract void Atender();

        public void FinalizarAtencion()
        {
            AtencionFinalizada(this.pacienteActual,this);
            this.pacienteActual = null;
        }

        public override string ToString()
        {
            return base.ToString();
        }



        public event FinAtencionPaciente AtencionFinalizada;


    }
}
