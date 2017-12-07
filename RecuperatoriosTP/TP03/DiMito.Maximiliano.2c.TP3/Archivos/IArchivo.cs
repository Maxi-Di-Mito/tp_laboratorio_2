using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivo<T>
    {
        bool Guardar(String path, T dato);

        bool Leer(String path, out T dato);
    }
}
