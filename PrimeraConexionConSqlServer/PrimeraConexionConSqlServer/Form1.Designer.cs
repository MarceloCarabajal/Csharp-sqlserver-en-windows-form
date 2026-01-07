namespace PrimeraConexionConSqlServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvClinica = new DataGridView();
            label1 = new Label();
            txtIdClinica = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClinica).BeginInit();
            SuspendLayout();
            // 
            // dgvClinica
            // 
            dgvClinica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClinica.Location = new Point(12, 102);
            dgvClinica.Name = "dgvClinica";
            dgvClinica.Size = new Size(680, 312);
            dgvClinica.TabIndex = 0;
            dgvClinica.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 31);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Id Clinica";
            label1.Click += label1_Click;
            // 
            // txtIdClinica
            // 
            txtIdClinica.Location = new Point(236, 28);
            txtIdClinica.Name = "txtIdClinica";
            txtIdClinica.Size = new Size(255, 23);
            txtIdClinica.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(497, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(578, 28);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtIdClinica);
            Controls.Add(label1);
            Controls.Add(dgvClinica);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClinica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClinica;
        private Label label1;
        private TextBox txtIdClinica;
        private Button btnBuscar;
        private Button btnLimpiar;
    }
}
