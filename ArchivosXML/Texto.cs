using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ArchivosXML
{
    public class Texto:IArchivo<string>
    {

        public bool guardar(string archivo, string datos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(string));

            using( XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
            {
                serializer.Serialize(writer, datos);
            }

            return true;
        }

        public bool leer(string archivo, out string datos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(string));

            using (XmlTextReader reader = new XmlTextReader(archivo))
            {
                datos = (string)serializer.Deserialize(reader);
            }

            return true;
        }
    }
}
