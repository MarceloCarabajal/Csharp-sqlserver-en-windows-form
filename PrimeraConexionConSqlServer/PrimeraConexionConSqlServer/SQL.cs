using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraConexionConSqlServer
{
    public class SQL
    {
        private static SqlConnection cn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["cnx"].ConnectionString
        );

        public static void ListarConsultaSQL(string consulta, DataGridView grilla)
        {
            SqlCommand cmd = new SqlCommand(
                 consulta, cn);

            DataTable tabla = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(tabla);

            grilla.DataSource = tabla;
        }

        public static void ListarProcedureQSL(string nombreProcedure, DataGridView grilla) {             
            SqlCommand cmd = new SqlCommand(nombreProcedure, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tabla);
            grilla.DataSource = tabla;
        }
    }
}
