namespace PrimeraConexionConSqlServer
{
    partial class frmListadoPaciente
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
            dgvPaciente = new DataGridView();
            label1 = new Label();
            cbOpcion = new ComboBox();
            label2 = new Label();
            txtValor = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPaciente
            // 
            dgvPaciente.AllowUserToAddRows = false;
            dgvPaciente.AllowUserToDeleteRows = false;
            dgvPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaciente.Location = new Point(1, 134);
            dgvPaciente.Name = "dgvPaciente";
            dgvPaciente.ReadOnly = true;
            dgvPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaciente.Size = new Size(797, 304);
            dgvPaciente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 100);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccione Criterio de Busqueda";
            label1.Click += label1_Click;
            // 
            // cbOpcion
            // 
            cbOpcion.FormattingEnabled = true;
            cbOpcion.Items.AddRange(new object[] { "Nombre", "Apellido Paterno", "Apellido Materno" });
            cbOpcion.Location = new Point(191, 96);
            cbOpcion.Name = "cbOpcion";
            cbOpcion.Size = new Size(154, 23);
            cbOpcion.TabIndex = 2;
            cbOpcion.SelectedIndexChanged += cbOpcion_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 99);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingrese Valor";
            label2.Click += label2_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(444, 96);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(184, 23);
            txtValor.TabIndex = 4;
            txtValor.TextChanged += filtrar;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnNuevo);
            flowLayoutPanel1.Controls.Add(btnEditar);
            flowLayoutPanel1.Controls.Add(btnEliminar);
            flowLayoutPanel1.Controls.Add(btnImprimir);
            flowLayoutPanel1.Location = new Point(1, 12);
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
            // frmListadoPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(cbOpcion);
            Controls.Add(label1);
            Controls.Add(dgvPaciente);
            Name = "frmListadoPaciente";
            Text = "frmListadoPaciente";
            Load += frmListadoPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPaciente;
        private Label label1;
        private ComboBox cbOpcion;
        private Label label2;
        private TextBox txtValor;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnImprimir;
    }
}