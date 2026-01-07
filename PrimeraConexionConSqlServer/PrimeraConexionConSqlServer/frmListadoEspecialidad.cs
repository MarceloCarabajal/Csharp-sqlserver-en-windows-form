using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraConexionConSqlServer
{
    public partial class frmListadoEspecialidad : Form
    {
        public frmListadoEspecialidad()
        {
            InitializeComponent();
        }

        private void frmListadoEspecialidad_Load(object sender, EventArgs e)
        {
            SQL.ListarProcedureQSL("uspListarEspecialidades", dgvEspecialidad);
            //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            //SqlCommand cmd = new SqlCommand("uspListarEspecialidades", cn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable tabla = new DataTable();
            //sda.Fill(tabla);
            //dgvEspecialidad.DataSource = tabla;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filtrar(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            SQL.filtradoDatos("uspListarEspecialidadPorNombre", "@NOMBRE", nombre, dgvEspecialidad);
        }
    }
}
