﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {
        static public bool Validar(int max, int min, int numero)
        {
            return numero < max && numero > min;
        }

    }
}
