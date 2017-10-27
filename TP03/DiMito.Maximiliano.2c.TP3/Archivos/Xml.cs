using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T>:IArchivo<T>
    {

        public bool Guardar(string path, T dato)
        {
            XmlSerializer serializer = null;
            XmlWriter writer = null;
            try
            {
                serializer = new XmlSerializer(dato.GetType());
                writer = XmlWriter.Create(path);
                serializer.Serialize(writer,dato);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return false;
            }
            finally
            {
                writer.Close();
            }
        }

        public bool Leer(string path, out T dato)
        {
            throw new NotImplementedException();
        }
    }
}
