using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ArchivosXML
{
    class Xml<T>:IArchivo<T>
    {
        public bool guardar(string archivo, T datos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
            {
                serializer.Serialize(writer, datos);
            }

            return true;
        }

        public bool leer(string archivo, out T datos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (XmlTextReader reader = new XmlTextReader(archivo))
            {
                datos = (T)serializer.Deserialize(reader);
            }

            return true;
        }
    }
}
