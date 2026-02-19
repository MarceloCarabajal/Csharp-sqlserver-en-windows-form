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

        private void dgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPopupMedicamentos ofrmPopupMedicamentos = new frmPopupMedicamentos();
            ofrmPopupMedicamentos.accion = "Nuevo";
            ofrmPopupMedicamentos.ShowDialog();
            if(ofrmPopupMedicamentos.DialogResult == DialogResult.OK)
            {
                SQL.ListarProcedureQSL("uspListarMedicamentoPrograma", dgvMedicamentos);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmPopupMedicamentos ofrmPopupMedicamentos = new frmPopupMedicamentos();
            ofrmPopupMedicamentos.accion = "Editar";
            ofrmPopupMedicamentos.ShowDialog();
        }
    }
}
