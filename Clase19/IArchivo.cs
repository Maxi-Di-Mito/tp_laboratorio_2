using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19
{
    interface IArchivo<T>
    {
        bool guardar(string archivo, T datos);

        bool leer(string archivo, T Datos);
    }
}
