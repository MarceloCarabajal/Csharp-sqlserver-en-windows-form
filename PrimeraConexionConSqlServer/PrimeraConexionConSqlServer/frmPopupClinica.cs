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
using System.Collections;

namespace PrimeraConexionConSqlServer
{
    public partial class frmPopupClinica : Form
    {
        public string accion { get; set; }
        public string id { get; set; }
        public frmPopupClinica()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmPopupClinica_Load(object sender, EventArgs e)
        {
            if (accion.Equals("Nuevo"))
            {
                this.Text = "Nueva Clinica";
            }
            else
            {
                this.Text = "Editar Clinica";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;

            bool exito = SQL.validarRequeridos(this.Controls, errorDatos);
            if(!exito)
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            if (accion.Equals("Nuevo"))
            {
                //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
                //cn.Open();
                //SqlCommand cmd = new SqlCommand("uspInsertarClinica", cn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@nombre", nombre);
                //cmd.Parameters.AddWithValue("@direccion", direccion);
                //int resultado = cmd.ExecuteNonQuery();
                int resultado = SQL.registrarYActualizarYEliminar("uspInsertarClinica", new ArrayList { "@nombre", "@direccion" }, new ArrayList { nombre, direccion });

                if (resultado == 1)
                {
                    MessageBox.Show("Clinica registrada correctamente");
                }
                else
                {
                    MessageBox.Show("Ya se encuentra registrada la sede de la clinica");
                    this.DialogResult = DialogResult.None;
                }
                //cn.Close();
            }
        }

        private void txtIdClinica_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
