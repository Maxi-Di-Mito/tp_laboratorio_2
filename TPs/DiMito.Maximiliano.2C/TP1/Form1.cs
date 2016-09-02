using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class frmCalculadora : Form
    {       

        public frmCalculadora()
        {
            InitializeComponent();
            this.cmbOperacion.Items.AddRange(Calculadora.operadores);   
            this.cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero n1 = new Numero(this.txtNumero1.Text);
            Numero n2 = new Numero(this.txtNumero2.Text);
            string operacion = this.cmbOperacion.Text;
            this.lblResultado.Text = Calculadora.Operar(n1, n2, operacion).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
        }



    }
}
