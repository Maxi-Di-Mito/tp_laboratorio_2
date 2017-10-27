using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException: Exception
    {
        private String mensajeBase;

        public DniInvalidoException(){}

        public DniInvalidoException(Exception e) : base("",e) { }

        public DniInvalidoException(String message) : base(message) { }

        public DniInvalidoException(String message, Exception e) : base(message, e) { }

    }
}
