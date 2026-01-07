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
    public partial class frmConsultarMedicoPorEspecialidad : Form
    {
        public frmConsultarMedicoPorEspecialidad()
        {
            InitializeComponent();
        }

        private void frmConsultarMedicoPorEspecialidad_Load(object sender, EventArgs e)
        {
            SQL.llenarComboBox("USPLISTARCOMBOESPEC", cboEspecialidad, "NOMBRE", "IIDESPECIALIDAD");
            SQL.ListarProcedureQSL("usplistarmedicos", dgvMedico);
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            SQL.filtradoDatos("USPCONSULTARDOCTORPORESPECIALIDAD", "@IIDESPECIALIDAD", cboEspecialidad.SelectedValue.ToString(), dgvMedico);
        }
    }
}
