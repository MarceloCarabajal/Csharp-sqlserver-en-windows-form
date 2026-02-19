namespace PrimeraConexionConSqlServer
{
    partial class frmPopupClinica
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
            txtIdClinica = new TextBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            errorDatos = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 46);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Id Clinica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 98);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 161);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // txtIdClinica
            // 
            txtIdClinica.Location = new Point(145, 38);
            txtIdClinica.Name = "txtIdClinica";
            txtIdClinica.ReadOnly = true;
            txtIdClinica.Size = new Size(100, 23);
            txtIdClinica.TabIndex = 3;
            txtIdClinica.TextChanged += txtIdClinica_TextChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(145, 153);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(318, 182);
            txtDireccion.TabIndex = 4;
            txtDireccion.Tag = "O";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(318, 23);
            txtNombre.TabIndex = 5;
            txtNombre.Tag = "O";
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(114, 375);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(230, 375);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorDatos
            // 
            errorDatos.ContainerControl = this;
            // 
            // frmPopupClinica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Controls.Add(txtDireccion);
            Controls.Add(txtIdClinica);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPopupClinica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPopupClinica";
            Load += frmPopupClinica_Load;
            ((System.ComponentModel.ISupportInitialize)errorDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdClinica;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Button btnAceptar;
        private Button btnCancelar;
        private ErrorProvider errorDatos;
    }
}