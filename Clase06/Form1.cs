using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06
{
    public partial class Form1 : Form
    {
        private int contadorDeClicks;
        private Color[] colores = { Color.Purple, Color.Red, Color.Yellow, Color.Green };

        public Form1()
        {
            InitializeComponent();
            this.contadorDeClicks = 0;
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            this.lblLabel.Text = "Hola mundo";
            this.Text = "Bienvenidos " + DateTime.Now;
            this.contadorDeClicks++;
            if (contadorDeClicks >= colores.Length)
            {
                contadorDeClicks = 0;
            }
            this.BackColor = colores[contadorDeClicks];            
        }

        

        
    }
}
