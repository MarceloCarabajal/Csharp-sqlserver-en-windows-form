namespace PrimeraConexionConSqlServer
{
    partial class frmListadoEspecialidad
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
            dgvEspecialidad = new DataGridView();
            txtNameLabel = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).BeginInit();
            SuspendLayout();
            // 
            // dgvEspecialidad
            // 
            dgvEspecialidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidad.Location = new Point(12, 83);
            dgvEspecialidad.Name = "dgvEspecialidad";
            dgvEspecialidad.Size = new Size(615, 355);
            dgvEspecialidad.TabIndex = 0;
            // 
            // txtNameLabel
            // 
            txtNameLabel.AutoSize = true;
            txtNameLabel.Location = new Point(75, 26);
            txtNameLabel.Name = "txtNameLabel";
            txtNameLabel.Size = new Size(135, 15);
            txtNameLabel.TabIndex = 1;
            txtNameLabel.Text = "Nombre de especialidad";
            txtNameLabel.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(216, 23);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(345, 23);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += filtrar;
            // 
            // frmListadoEspecialidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(txtNameLabel);
            Controls.Add(dgvEspecialidad);
            Name = "frmListadoEspecialidad";
            Text = "frmListadoEspecialidad";
            Load += filtrar;
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEspecialidad;
        private Label txtNameLabel;
        private TextBox txtNombre;
    }
}