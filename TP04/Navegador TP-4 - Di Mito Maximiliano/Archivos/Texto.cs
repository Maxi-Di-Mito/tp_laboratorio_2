using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        private string path;

        public Texto(string archivo)
        {
            this.path = archivo;
        }

        public bool guardar(string datos)
        {
            try
            {
                StreamWriter writer = new StreamWriter(this.path,true);
                writer.WriteLine(datos);

                writer.Flush();
                writer.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return false;
            }
            
        }

        public bool leer(out List<string> datos)
        {
            try
            {
                List<String> leidos = new List<string>();
                StreamReader reader = new StreamReader(this.path);
                while (!reader.EndOfStream)
                    leidos.Add(reader.ReadLine());

                reader.Close();
                datos = leidos;
                return true;


            }
            catch (Exception ex)
            {
                Console.Write(ex);
                datos = null;
                return false;
            }
            
        }
    }
}
