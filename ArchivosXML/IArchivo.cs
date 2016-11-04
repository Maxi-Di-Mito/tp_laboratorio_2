using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosXML
{
    public interface IArchivo<T>
    {
        bool guardar(string archivo, T datos);

        bool leer(string archivo, T datos);
    }
}
