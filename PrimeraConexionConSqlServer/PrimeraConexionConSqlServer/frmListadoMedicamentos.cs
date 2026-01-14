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
    public partial class frmListadoMedicamentos : Form
    {
        public frmListadoMedicamentos()
        {
            InitializeComponent();
        }

        private void frmListadoMedicamentos_Load(object sender, EventArgs e)
        {
            rbNombre.Checked = true;
            SQL.ListarProcedureQSL("uspListarMedicamentoPrograma", dgvMedicamentos);
        }

        private void filtrar(object sender, EventArgs e)
        {
            string valor = txtMedicamentos.Text;
            if (rbNombre.Checked)
            {
                SQL.filtradoDatos("uspConsultarMedicamentoPorNombre", "@nombre", valor, dgvMedicamentos);
            }
            else
            {
                 SQL.filtradoDatos("uspConsultarMedicamentoPorConcentracion", "@concentracion", valor, dgvMedicamentos);
            }
        }
    }
}
