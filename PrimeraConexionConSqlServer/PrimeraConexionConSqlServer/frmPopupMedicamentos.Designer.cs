namespace PrimeraConexionConSqlServer
{
    partial class frmPopupMedicamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtConcentracion = new TextBox();
            cboFormaFarmaceutica = new ComboBox();
            txtPrecio = new NumericUpDown();
            txtPresentacion = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            errorDatos = new ErrorProvider(components);
            txtStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 59);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 101);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Concentracion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 148);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 2;
            label3.Text = "Forma Farmaceutica";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 231);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 189);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 274);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 5;
            label6.Text = "Presentacion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(179, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(324, 23);
            txtNombre.TabIndex = 6;
            txtNombre.Tag = "O";
            // 
            // txtConcentracion
            // 
            txtConcentracion.Location = new Point(179, 93);
            txtConcentracion.Name = "txtConcentracion";
            txtConcentracion.Size = new Size(324, 23);
            txtConcentracion.TabIndex = 7;
            txtConcentracion.Tag = "O";
            // 
            // cboFormaFarmaceutica
            // 
            cboFormaFarmaceutica.FormattingEnabled = true;
            cboFormaFarmaceutica.Location = new Point(179, 140);
            cboFormaFarmaceutica.Name = "cboFormaFarmaceutica";
            cboFormaFarmaceutica.Size = new Size(324, 23);
            cboFormaFarmaceutica.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(179, 181);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(324, 23);
            txtPrecio.TabIndex = 9;
            txtPrecio.Tag = "O";
            // 
            // txtPresentacion
            // 
            txtPresentacion.Location = new Point(179, 266);
            txtPresentacion.Name = "txtPresentacion";
            txtPresentacion.Size = new Size(324, 23);
            txtPresentacion.TabIndex = 11;
            txtPresentacion.Tag = "O";
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(227, 371);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(392, 371);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorDatos
            // 
            errorDatos.ContainerControl = this;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(179, 223);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(324, 23);
            txtStock.TabIndex = 14;
            txtStock.Tag = "O";
            // 
            // frmPopupMedicamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 450);
            Controls.Add(txtStock);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPresentacion);
            Controls.Add(txtPrecio);
            Controls.Add(cboFormaFarmaceutica);
            Controls.Add(txtConcentracion);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPopupMedicamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPopupMedicamentos";
            Load += frmPopupMedicamentos_Load;
            ((System.ComponentModel.ISupportInitialize)txtPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtConcentracion;
        private ComboBox cboFormaFarmaceutica;
        private NumericUpDown txtPrecio;
        private TextBox txtPresentacion;
        private Button btnCancelar;
        private Button btnAceptar;
        private ErrorProvider errorDatos;
        private NumericUpDown txtStock;
    }
}