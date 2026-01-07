using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PrimeraConexionConSqlServer
{
    public partial class frmConsultaMedicamentoPorFormaFarmaceutica : Form
    {
        public frmConsultaMedicamentoPorFormaFarmaceutica()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboFormaFarmaceutica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmConsultaMedicamentoPorFormaFarmaceutica_Load(object sender, EventArgs e)
        {
            SQL.llenarComboBox("uspLlenarComboFormaFarmaceutica", cboFormaFarmaceutica, "NOMBRE", "Id");
            SQL.ListarProcedureQSL("USPLISTARMEDICAMENTOS", dgvMedicamentos);
            //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            //SqlCommand cmd = new SqlCommand("uspLlenarComboFormaFarmaceutica", cn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable tabla = new DataTable();
            //sda.Fill(tabla);
            //cboFormaFarmaceutica.DataSource = tabla;
            //cboFormaFarmaceutica.DisplayMember = "NOMBRE";
            //cboFormaFarmaceutica.ValueMember = "IIDFORMAFARMACEUTICA";
        }

        private void dgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filtrar(object sender, EventArgs e)
        {
            string idforma = cboFormaFarmaceutica.SelectedValue.ToString();
            SQL.filtradoDatos("USPCONSULTARMEDICAMENTOSPORFORMAFARMACEUTICA", "@IIDFORMAFARMACEUTICA", idforma, dgvMedicamentos);
        }
    }
}
