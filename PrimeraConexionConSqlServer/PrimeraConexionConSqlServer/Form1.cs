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
            listar();
        }

        private void listar()
        {
            SQL.ListarConsultaSQL("SELECT IIDCLINICA, NOMBRE, DIRECCION FROM CLINICA WHERE BHABILITADO = 1", dgvClinica);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idclinica = txtIdClinica.Text;
            SQL.filtradoDatos("uspFiltrarClinicaPorId", "@idclinica", idclinica, dgvClinica);
            //SqlConnection cn = new SqlConnection(
            //    ConfigurationManager.ConnectionStrings["cnx"].ConnectionString
            //);
            //SqlCommand cmd = new SqlCommand("uspFiltrarClinicaPorId", cn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@idclinica", idclinica);
            //DataTable tabla = new DataTable();
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //sda.Fill(tabla);
            //dgvClinica.DataSource = tabla;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listar();
            txtIdClinica.Text = "";
        }

    }
}
