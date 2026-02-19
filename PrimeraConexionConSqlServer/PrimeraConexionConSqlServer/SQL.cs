using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public static void filtradoDatos(string nombreProcedure, string nombreParametro, string valorParametro, DataGridView grilla)
        {
            SqlCommand cmd = new SqlCommand(nombreProcedure, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(nombreParametro, valorParametro);
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tabla);
            grilla.DataSource = tabla;
        }

        public static void llenarComboBox(string nombreProcedure, ComboBox combo, string displayMember = "Nombre", string valueMember = "Id")
        {
            SqlCommand cmd = new SqlCommand(nombreProcedure, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sda.Fill(tabla);
         
            combo.DataSource = tabla;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }

        public static int registrarYActualizarYEliminar(
            string nombreProcedure, ArrayList parametros, ArrayList valores)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand(nombreProcedure, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parametros.Count; i++)
            {
                cmd.Parameters.AddWithValue(parametros[i].ToString(), valores[i]);
            }

            int resultado = cmd.ExecuteNonQuery();

            cn.Close();

            return resultado;
        }
        public static bool validarRequeridos(Control.ControlCollection controles, ErrorProvider error)
        {
            bool exito = true;
            int nControles= controles.Count;
            Control control;
            for(int i = 0; i < nControles; i++)
            {
                control = controles[i];
                if(control is TextBox)
                {
                    if(control.Tag!= null && control.Tag.ToString().Equals("O"))
                    {
                        if (((TextBox)control).Text.Equals(""))
                        {
                            error.SetError(control, "Este campo es requerido");
                            exito = false;
                        }
                        else
                        {
                            error.SetError(control, "");
                        }
                    }
                } else if (control is NumericUpDown)
                {
                    if (control.Tag != null && control.Tag.ToString().Equals("O"))
                    {
                        if (((NumericUpDown)control).Value.Equals(0))
                        {
                            error.SetError(control, "Este campo es requerido");
                            exito = false;
                        }
                        else
                        {
                            error.SetError(control, "");
                        }
                    }
                }
            }
            return exito;
        }
    }
}
