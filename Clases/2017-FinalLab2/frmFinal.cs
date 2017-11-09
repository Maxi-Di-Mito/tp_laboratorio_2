using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_FinalLab2
{
    public partial class frmFinal : Form
    {
        MEspecialista medicoEspecialista;
        MGeneral medicoGeneral;
        Thread mocker;
        private Queue<Paciente> pacientesEnEspera;


        public frmFinal()
        {
            
            this.pacientesEnEspera = new Queue<Paciente>();
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias",MEspecialista.Especialidad.Traumatologo);
            this.medicoGeneral.AtencionFinalizada += this.FinAtencion;
            this.medicoEspecialista.AtencionFinalizada += this.FinAtencion;
            
            InitializeComponent();
        }

        private void AtenderPacientes(IMedico iMedico)
        {
            if(this.pacientesEnEspera.Count > 0)
                iMedico.IniciarAtencion(this.pacientesEnEspera.Dequeue());
        }

        private void btnEspecialista_Click(Object sender, EventArgs e)
        {
            this.AtenderPacientes(this.medicoEspecialista);
        }

        private void btnGeneral_Click(Object sender, EventArgs e)
        {
            this.AtenderPacientes(this.medicoGeneral);
        }

        private void FinAtencion(Paciente p, Medico m)
        {
            MessageBox.Show(String.Format("Finalizo la atencion de {0} por {1}!",p.ToString(),m.ToString()));
        }


        private void frmFinal_FormClosing(Object sender, FormClosedEventArgs e)
        {
            if (this.mocker.IsAlive)
            {
                this.mocker.Abort();
            }
        }

        private void frmFinal_Load(Object sender, EventArgs e)
        {

            this.mocker = new Thread(this.MockPacientes);
            this.mocker.Start();
        }


        private void MockPacientes()
        {
            while (true)
            {
                Thread.Sleep(5000);
                this.pacientesEnEspera.Enqueue(new Paciente("Juancito", "Hipocondriaco"));
            }
        }

    }
}
