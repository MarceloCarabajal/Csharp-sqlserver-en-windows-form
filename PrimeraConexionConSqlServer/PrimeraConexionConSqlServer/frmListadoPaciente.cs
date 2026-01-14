using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraConexionConSqlServer
{
    public partial class frmListadoPaciente : Form
    {
        public frmListadoPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmListadoPaciente_Load(object sender, EventArgs e)
        {
            cbOpcion.SelectedIndex = 0;
            SQL.ListarProcedureQSL("uspListarPacientesPrograma", dgvPaciente);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void filtrar(object sender, EventArgs e)
        {
            string opcion = cbOpcion.Text;
            if (opcion.Equals("Nombre"))
            {
                string valor = txtValor.Text;
                SQL.filtradoDatos("uspConsultarPacientesProgramaPorNombre", "@nombre", valor, dgvPaciente);
            }
            else if (opcion.Equals("Apellido Paterno"))
            {
                string valor = txtValor.Text;
                SQL.filtradoDatos("uspConsultarPacientesProgramaPorApPaterno", "@apPaterno", valor, dgvPaciente);
            }
            else
            {
                string valor = txtValor.Text;
                SQL.filtradoDatos("uspConsultarPacientesProgramaPorApMaterno", "@apMaterno", valor, dgvPaciente);
            }
        }
    }
}
