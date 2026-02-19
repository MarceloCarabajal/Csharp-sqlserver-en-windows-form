namespace PrimeraConexionConSqlServer
{
    partial class frmListadoMedicamentos
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
            dgvMedicamentos = new DataGridView();
            rbNombre = new RadioButton();
            rbConcentracion = new RadioButton();
            txtMedicamentos = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.AllowUserToAddRows = false;
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Location = new Point(12, 158);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.ReadOnly = true;
            dgvMedicamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicamentos.Size = new Size(612, 280);
            dgvMedicamentos.TabIndex = 0;
            dgvMedicamentos.CellContentClick += dgvMedicamentos_CellContentClick;
            // 
            // rbNombre
            // 
            rbNombre.AutoSize = true;
            rbNombre.Location = new Point(12, 118);
            rbNombre.Name = "rbNombre";
            rbNombre.Size = new Size(69, 19);
            rbNombre.TabIndex = 1;
            rbNombre.TabStop = true;
            rbNombre.Text = "Nombre";
            rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbConcentracion
            // 
            rbConcentracion.AutoSize = true;
            rbConcentracion.Location = new Point(98, 118);
            rbConcentracion.Name = "rbConcentracion";
            rbConcentracion.Size = new Size(103, 19);
            rbConcentracion.TabIndex = 2;
            rbConcentracion.TabStop = true;
            rbConcentracion.Text = "Concentracion";
            rbConcentracion.UseVisualStyleBackColor = true;
            // 
            // txtMedicamentos
            // 
            txtMedicamentos.Location = new Point(207, 114);
            txtMedicamentos.Name = "txtMedicamentos";
            txtMedicamentos.Size = new Size(305, 23);
            txtMedicamentos.TabIndex = 3;
            txtMedicamentos.TextChanged += filtrar;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnNuevo);
            flowLayoutPanel1.Controls.Add(btnEditar);
            flowLayoutPanel1.Controls.Add(btnEliminar);
            flowLayoutPanel1.Controls.Add(btnImprimir);
            flowLayoutPanel1.Location = new Point(12, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(680, 28);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(3, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(84, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(165, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(246, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // frmListadoMedicamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtMedicamentos);
            Controls.Add(rbConcentracion);
            Controls.Add(rbNombre);
            Controls.Add(dgvMedicamentos);
            Name = "frmListadoMedicamentos";
            Text = "frmListadoMedicamentos";
            Load += frmListadoMedicamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMedicamentos;
        private RadioButton rbNombre;
        private RadioButton rbConcentracion;
        private TextBox txtMedicamentos;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnImprimir;
    }
}