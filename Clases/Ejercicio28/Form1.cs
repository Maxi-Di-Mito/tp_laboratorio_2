using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonCalcular_Click(object sender, EventArgs e)
        {
            String[] palabras = this.texto.Text.Split(' ');
            Dictionary<String, int> contador = new Dictionary<string, int>();

            foreach (String p in palabras)
            {
                int cant;
                if (contador.TryGetValue(p, out cant))
                {
                    cant++;
                    contador[p] =  cant;
                }
                else
                {
                    cant = 1;
                    contador.Add(p, cant);
                }
            }


            List<String> keyList = contador.Keys.ToList<String>();
            keyList.Sort( delegate (String a, String b)
            {
                return contador[b] - contador[a];
            });
            List<String> masEscritas = keyList.GetRange(0, 3).ToList<String>();

            MessageBox.Show("Las tres palabras mas escritas son: "+masEscritas[0]+", "+masEscritas[1]+", "+masEscritas[2]);

        }
    }
}
