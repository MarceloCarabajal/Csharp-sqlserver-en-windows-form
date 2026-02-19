using System;
using System.Collections;
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
    public partial class frmPopupMedicamentos : Form
    {
        public string accion { get; set; }
        public string id { get; set; }

        public frmPopupMedicamentos()
        {
            InitializeComponent();
        }

        private void frmPopupMedicamentos_Load(object sender, EventArgs e)
        {
            SQL.llenarComboBox("USPLLENARCOMBOFORMAFARMACEUTICA", cboFormaFarmaceutica, "NOMBRE", "Id");
            if (accion.Equals("Nuevo"))
            {
                this.Text = "Nuevo Medicamento";
            }
            else
            {
                this.Text = "Editar Medicamento";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string concentracion = txtConcentracion.Text;
            string iidformaFarmaceutica = cboFormaFarmaceutica.SelectedValue.ToString();
            decimal precio = txtPrecio.Value;
            int stock = int.Parse(txtStock.Text);
            string presentacion = txtPresentacion.Text;

            bool exito = SQL.validarRequeridos(this.Controls, errorDatos);

            if (!exito)
            {
                this.DialogResult = DialogResult.None;
                return;
            }
            if (accion.Equals("Nuevo"))
            {
                int n = SQL.registrarYActualizarYEliminar("USPINSERTARMEDICAMENTOS", new ArrayList() { "@NOMBRE", "@CONCENTRACION", "@IIDFORMAFARMACEUTICA", "@PRECIO", "@STOCK", "@PRESENTACION" },
                    new ArrayList() { nombre, concentracion, iidformaFarmaceutica, precio, stock, presentacion });
                if (n == 1)
                {
                    MessageBox.Show("Medicamento registrado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al registrar el medicamento");
                }
            }
          
        }

    }
}
