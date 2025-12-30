using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
namespace PrimeraConexionConSqlServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQL.ListarConsultaSQL("SELECT IIDCLINICA, NOMBRE, DIRECCION FROM CLINICA WHERE BHABILITADO = 1", dgvClinica);
        }
    }
}
