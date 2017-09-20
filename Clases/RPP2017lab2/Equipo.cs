using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP2017lab2
{
    public class Equipo
    {
        private static Deportes _deporte;
        private DirectorTecnico _dt;
        private List<Jugador> _jugadores;
        private String _nombre;

        public static Deportes Deporte
        {
            set
            {
                Equipo._deporte = value;
            }
        }


        static Equipo()
        {
            Equipo.Deporte = Deportes.Futbol;
        }

        private Equipo()
        {
            this._jugadores = new List<Jugador>();
        }

        public Equipo(String nombre, DirectorTecnico dt)
            :this()
        {
            this._nombre = nombre;
            this._dt = dt;
        }

        public Equipo(String nombre, DirectorTecnico dt, Deportes deporte)
            :this(nombre,dt)
        {
            Equipo.Deporte = deporte;
        }       

        public static bool operator ==(Equipo e, Jugador j)
        {
            if (e._jugadores.Contains<Jugador>(j))
                return true;
            else
                return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j)
                e._jugadores.Add(j);
            return e;
        }

        public static Equipo operator -(Equipo e, Jugador j)
        {
            if (e == j)
                e._jugadores.Remove(j);
            return e;
        }

        public static implicit operator String(Equipo e)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(String.Format("**{0} {1}**",e._nombre,Equipo._deporte.ToString()));
            builder.AppendLine("Nomina Jugadores:");
            foreach (Jugador j in e._jugadores)
                builder.AppendLine(j.ToString());
            builder.AppendLine("Dirigido por: " + e._dt.ToString());

            return builder.ToString();
        }



        public enum Deportes
        {
            Futbol,
            Basket,
            HandBall,
            Rugby
        }

    }
}
