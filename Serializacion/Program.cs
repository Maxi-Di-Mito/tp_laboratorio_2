using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter("hola.xml", Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));
                Persona p = new Persona("Maxi", "Di Mito", 35639526);
                //Persona pp = new Persona("Franco", "Guerendiain", 35639526);
                //Persona ppp = new Persona("Daniel", "Gomez", 35639526);
                List<Persona> lista = new List<Persona>();
                lista.Add(p);
                //lista.Add(pp);
                //lista.Add(ppp);
                PersonaH h = new PersonaH("Mario", "Aloja", 123, "hoja");
                lista.Add(h);
                List<Persona> listaLeida;
                serializer.Serialize(writer, lista);                
                
                writer.Close();

                using (XmlTextReader reader = new XmlTextReader("hola.xml"))
                {
                    listaLeida = (List<Persona>)serializer.Deserialize(reader);
                }
                
                lista.ForEach(delegate(Persona p1) { Console.WriteLine(p1); });

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            

            
            
            Console.ReadKey();
        }
    }
}
