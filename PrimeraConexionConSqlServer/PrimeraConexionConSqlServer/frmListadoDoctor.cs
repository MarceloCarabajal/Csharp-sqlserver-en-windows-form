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
    public partial class frmListadoDoctor : Form
    {
        public frmListadoDoctor()
        {
            InitializeComponent();
        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListadoDoctor_Load(object sender, EventArgs e)
        {
            rbApPaterno.Checked = true;
            SQL.ListarProcedureQSL("uspListarDoctorPrograma", dgvDoctor);
        }

        private void filtrar(object sender, EventArgs e)
        {
            string valor = txtValor.Text;
            if (rbApPaterno.Checked)
            {
                SQL.filtradoDatos("uspConsultaDoctorPorApPaterno", "@apPaterno", valor, dgvDoctor);
            }
            else
            {
                SQL.filtradoDatos("uspConsultaDoctorPorApMaterno", "@apMaterno", valor, dgvDoctor);
            }
        }
    }
}
