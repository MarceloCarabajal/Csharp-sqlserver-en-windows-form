namespace PrimeraConexionConSqlServer
{
    partial class frmConsultaMedicamentoPorFormaFarmaceutica
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
            label1 = new Label();
            cboFormaFarmaceutica = new ComboBox();
            dgvMedicamentos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 54);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Forma Farmaceutica";
            label1.Click += label1_Click;
            // 
            // cboFormaFarmaceutica
            // 
            cboFormaFarmaceutica.FormattingEnabled = true;
            cboFormaFarmaceutica.Location = new Point(186, 51);
            cboFormaFarmaceutica.Name = "cboFormaFarmaceutica";
            cboFormaFarmaceutica.Size = new Size(378, 23);
            cboFormaFarmaceutica.TabIndex = 1;
            cboFormaFarmaceutica.SelectedIndexChanged += cboFormaFarmaceutica_SelectedIndexChanged;
            cboFormaFarmaceutica.SelectionChangeCommitted += filtrar;
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Location = new Point(12, 99);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.Size = new Size(552, 305);
            dgvMedicamentos.TabIndex = 2;
            dgvMedicamentos.CellContentClick += dgvMedicamentos_CellContentClick;
            // 
            // frmConsultaMedicamentoPorFormaFarmaceutica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMedicamentos);
            Controls.Add(cboFormaFarmaceutica);
            Controls.Add(label1);
            Name = "frmConsultaMedicamentoPorFormaFarmaceutica";
            Text = "frmConsultaMedicamentoPorFormaFarmaceutica";
            Load += frmConsultaMedicamentoPorFormaFarmaceutica_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboFormaFarmaceutica;
        private DataGridView dgvMedicamentos;
    }
}