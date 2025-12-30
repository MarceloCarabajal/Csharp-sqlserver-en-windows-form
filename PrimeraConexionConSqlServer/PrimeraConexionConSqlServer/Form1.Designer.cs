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
            ((System.ComponentModel.ISupportInitialize)dgvClinica).BeginInit();
            SuspendLayout();
            // 
            // dgvClinica
            // 
            dgvClinica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClinica.Location = new Point(0, 0);
            dgvClinica.Name = "dgvClinica";
            dgvClinica.Size = new Size(788, 438);
            dgvClinica.TabIndex = 0;
            dgvClinica.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvClinica);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClinica).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClinica;
    }
}
