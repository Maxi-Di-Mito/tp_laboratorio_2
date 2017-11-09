using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_FinalLab2
{
    public class Paciente:Persona
    {
        private int turno;
        private static int ultimoTurnoDado;

        public int Turno
        {
            get
            {
                return this.turno;
            }
        }


        static Paciente()
        {
            Paciente.ultimoTurnoDado = 0;
        }

        public Paciente(String nombre, String apellido)
            :this(nombre,apellido, ++Paciente.ultimoTurnoDado)
        {            
        }

        public Paciente(String nombre, String apellido, int turno)
            : base(nombre, apellido)
        {
            this.turno = turno;
            Paciente.ultimoTurnoDado = turno;
        }

        public override string ToString()
        {
            return String.Format("Turno Nº{0}:: {1}, {2}", this.turno, base.apellido, base.nombre);
        }


    }
}
