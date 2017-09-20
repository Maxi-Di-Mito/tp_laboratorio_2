using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPP2017lab2
{
    public class DirectorTecnico:Persona
    {
        public DirectorTecnico(String nombre, String apellido)
            :base(nombre,apellido)
        {

        }

        protected override string FichaTecnica()
        {
            return base.NombreCompleto();
        }


        public override string ToString()
        {
            return this.FichaTecnica();
        }

    }
}
