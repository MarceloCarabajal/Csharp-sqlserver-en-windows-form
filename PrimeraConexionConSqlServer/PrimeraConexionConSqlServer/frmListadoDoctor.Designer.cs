namespace PrimeraConexionConSqlServer
{
    partial class frmListadoDoctor
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
            dgvDoctor = new DataGridView();
            rbApPaterno = new RadioButton();
            rbApMaterno = new RadioButton();
            txtValor = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDoctor
            // 
            dgvDoctor.AllowUserToAddRows = false;
            dgvDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctor.Location = new Point(12, 131);
            dgvDoctor.Name = "dgvDoctor";
            dgvDoctor.ReadOnly = true;
            dgvDoctor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctor.Size = new Size(660, 317);
            dgvDoctor.TabIndex = 0;
            dgvDoctor.CellContentClick += dgvDoctor_CellContentClick;
            // 
            // rbApPaterno
            // 
            rbApPaterno.AutoSize = true;
            rbApPaterno.Location = new Point(13, 93);
            rbApPaterno.Name = "rbApPaterno";
            rbApPaterno.Size = new Size(113, 19);
            rbApPaterno.TabIndex = 1;
            rbApPaterno.TabStop = true;
            rbApPaterno.Text = "Apellido Paterno";
            rbApPaterno.UseVisualStyleBackColor = true;
            // 
            // rbApMaterno
            // 
            rbApMaterno.AutoSize = true;
            rbApMaterno.Location = new Point(146, 93);
            rbApMaterno.Name = "rbApMaterno";
            rbApMaterno.Size = new Size(117, 19);
            rbApMaterno.TabIndex = 2;
            rbApMaterno.TabStop = true;
            rbApMaterno.Text = "Apellido Materno";
            rbApMaterno.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(296, 89);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(360, 23);
            txtValor.TabIndex = 3;
            txtValor.TextChanged += filtrar;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnNuevo);
            flowLayoutPanel1.Controls.Add(btnEditar);
            flowLayoutPanel1.Controls.Add(btnEliminar);
            flowLayoutPanel1.Controls.Add(btnImprimir);
            flowLayoutPanel1.Location = new Point(13, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(680, 28);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(3, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(84, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
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
            // frmListadoDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtValor);
            Controls.Add(rbApMaterno);
            Controls.Add(rbApPaterno);
            Controls.Add(dgvDoctor);
            Name = "frmListadoDoctor";
            Text = "frmListadoDoctor";
            Load += frmListadoDoctor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDoctor;
        private RadioButton rbApPaterno;
        private RadioButton rbApMaterno;
        private TextBox txtValor;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnImprimir;
    }
}