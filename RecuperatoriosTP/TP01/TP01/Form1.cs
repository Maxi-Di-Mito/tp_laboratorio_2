using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01
{
    public partial class Form1 : Form
    {
               
        public Form1()
        {
            InitializeComponent();
                        
            this.operacionCombo.DataSource = Calculadora.Operaciones;
            
        }

        private void OperarButton_Click(object sender, EventArgs e)
        {
            Numero op1 = new Numero(this.Operando1Textbox.Text);
            Numero op2 = new Numero(this.Operando2Textbox.Text);
            String op = (String)this.operacionCombo.SelectedItem;

            String result = Calculadora.Operar(op1, op2, op).ToString();

            this.ResultadoLabel.Text = result;

        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            this.Operando1Textbox.Text = "";
            this.Operando2Textbox.Text = "";
            this.operacionCombo.SelectedItem = Calculadora.Operaciones[0];
            this.ResultadoLabel.Text = "";
        }
    }
}
