namespace PrimeraConexionConSqlServer
{
    partial class frmConsultarMedicoPorEspecialidad
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
            cboEspecialidad = new ComboBox();
            Consultar = new Button();
            dgvMedico = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMedico).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 62);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Especialidad";
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Location = new Point(211, 62);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(256, 23);
            cboEspecialidad.TabIndex = 1;
            // 
            // Consultar
            // 
            Consultar.Location = new Point(490, 61);
            Consultar.Name = "Consultar";
            Consultar.Size = new Size(85, 23);
            Consultar.TabIndex = 2;
            Consultar.Text = "Consultar";
            Consultar.UseVisualStyleBackColor = true;
            Consultar.Click += Consultar_Click;
            // 
            // dgvMedico
            // 
            dgvMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedico.Location = new Point(12, 91);
            dgvMedico.Name = "dgvMedico";
            dgvMedico.Size = new Size(605, 333);
            dgvMedico.TabIndex = 3;
            // 
            // frmConsultarMedicoPorEspecialidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMedico);
            Controls.Add(Consultar);
            Controls.Add(cboEspecialidad);
            Controls.Add(label1);
            Name = "frmConsultarMedicoPorEspecialidad";
            Text = "frmConsultarMedicoPorEspecialidad";
            Load += frmConsultarMedicoPorEspecialidad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboEspecialidad;
        private Button Consultar;
        private DataGridView dgvMedico;
    }
}