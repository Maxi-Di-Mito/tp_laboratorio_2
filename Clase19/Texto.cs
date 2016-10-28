using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Clase19
{
    class Texto:IArchivo<string>
    {

        public bool guardar(string archivo, string datos)
        {
            using(StreamWriter sw = new StreamWriter(archivo))
            {
                sw.Write(datos);
                return true;
            }            
        }

        public bool leer(string archivo, out string datos)
        {
            using (StreamReader sw = new StreamReader(archivo))
            {
                datos = sw.ReadToEnd();
                return true;
            }
        }
    }
}
