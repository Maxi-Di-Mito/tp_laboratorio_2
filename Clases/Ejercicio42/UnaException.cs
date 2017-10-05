using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class UnaException:Exception
    {

        public UnaException(String message, Exception inner)
            :base(message,inner)
        {

        }


    }
}
