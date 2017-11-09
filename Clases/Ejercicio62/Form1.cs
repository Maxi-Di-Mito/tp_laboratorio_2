using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ejercicio62
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Threading.Timer t = new System.Threading.Timer((TimerCallback)this.doWork, null, 500, 1000);
            
        }

                    
        public void doWork(Object obj)
        {

            this.label1.BeginInvoke( (MethodInvoker) delegate ()
            {
                this.AsignarHora();
            });
        }
        

        
        public void AsignarHora()
        {
            this.label1.Text = DateTime.Now.ToString();
        }



    }
}
