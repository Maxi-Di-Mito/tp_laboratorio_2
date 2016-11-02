using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    public class PersonaH:Persona
    {
        public string _h;

        public PersonaH() { }

        public PersonaH(string n, string a, long d, string h)
            : base(n, a, d)
        {
            this._h = h;
        }


        public override string ToString()
        {
            return base.ToString() + "\nH: " + this._h;
        }

    }
}
