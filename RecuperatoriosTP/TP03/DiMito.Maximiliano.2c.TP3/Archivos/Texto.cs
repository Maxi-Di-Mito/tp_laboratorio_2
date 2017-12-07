using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto: IArchivo<String>
    {

        public bool Guardar(string path, string dato)
        {
            StreamWriter stream = null;
            try
            {
                stream = new StreamWriter(path);
                stream.Write(dato);
                stream.Flush();
                return true;
            }
            catch (IOException exception)
            {
                throw new ArchivosException(exception);                
            }
            finally
            {
                stream.Close();
            }
        }

        public bool Leer(string path, out string dato)
        {
            StreamReader stream = null;
            dato = null;
            try
            {
                stream = new StreamReader(path);
                dato = stream.ReadToEnd();                
                return true;
            }
            catch (IOException exception)
            {
                Console.Write(exception.ToString());                
                return false;
            }
            finally
            {
                stream.Close();
            }
        }
    }
}
