namespace Ejercicio_grupo_12___FTP
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
            txtFTPUrl = new TextBox();
            txtFTPUsuario = new TextBox();
            txtFTPContraseña = new TextBox();
            txtArchivoNombre = new TextBox();
            txtArchivoLocal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSubir = new Button();
            btnDescargar = new Button();
            btnGuardarLogs = new Button();
            lstLogs = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtFTPUrl
            // 
            txtFTPUrl.Location = new Point(188, 85);
            txtFTPUrl.Name = "txtFTPUrl";
            txtFTPUrl.Size = new Size(100, 23);
            txtFTPUrl.TabIndex = 0;
            // 
            // txtFTPUsuario
            // 
            txtFTPUsuario.Location = new Point(188, 126);
            txtFTPUsuario.Name = "txtFTPUsuario";
            txtFTPUsuario.Size = new Size(100, 23);
            txtFTPUsuario.TabIndex = 1;
            // 
            // txtFTPContraseña
            // 
            txtFTPContraseña.Location = new Point(188, 162);
            txtFTPContraseña.Name = "txtFTPContraseña";
            txtFTPContraseña.Size = new Size(100, 23);
            txtFTPContraseña.TabIndex = 2;
            // 
            // txtArchivoNombre
            // 
            txtArchivoNombre.Location = new Point(222, 227);
            txtArchivoNombre.Name = "txtArchivoNombre";
            txtArchivoNombre.Size = new Size(100, 23);
            txtArchivoNombre.TabIndex = 3;
            // 
            // txtArchivoLocal
            // 
            txtArchivoLocal.Location = new Point(522, 227);
            txtArchivoLocal.Name = "txtArchivoLocal";
            txtArchivoLocal.Size = new Size(186, 23);
            txtArchivoLocal.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 85);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 5;
            label1.Text = "Dirección del servidor FTP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 129);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 6;
            label2.Text = "Usuario del servidor FTP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 170);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 7;
            label3.Text = "Contraseña del servidor FTP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 230);
            label4.Name = "label4";
            label4.Size = new Size(204, 15);
            label4.TabIndex = 8;
            label4.Text = "Nombre del archivo (para descargas):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(328, 230);
            label5.Name = "label5";
            label5.Size = new Size(188, 15);
            label5.TabIndex = 9;
            label5.Text = "Ruta local para subidas/descargas:";
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(134, 282);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(75, 23);
            btnSubir.TabIndex = 10;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnDescargar
            // 
            btnDescargar.Location = new Point(261, 282);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(75, 23);
            btnDescargar.TabIndex = 11;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // btnGuardarLogs
            // 
            btnGuardarLogs.Location = new Point(387, 282);
            btnGuardarLogs.Name = "btnGuardarLogs";
            btnGuardarLogs.Size = new Size(75, 23);
            btnGuardarLogs.TabIndex = 12;
            btnGuardarLogs.Text = "Guardar";
            btnGuardarLogs.UseVisualStyleBackColor = true;
            btnGuardarLogs.Click += btnGuardarLogs_Click;
            // 
            // lstLogs
            // 
            lstLogs.FormattingEnabled = true;
            lstLogs.ItemHeight = 15;
            lstLogs.Location = new Point(134, 311);
            lstLogs.Name = "lstLogs";
            lstLogs.Size = new Size(328, 124);
            lstLogs.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Desktop;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 9);
            label6.Name = "label6";
            label6.Size = new Size(733, 30);
            label6.TabIndex = 14;
            label6.Text = "Trabajando con el Protocolo de Transferencia de Archivos con el Grupo19";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(lstLogs);
            Controls.Add(btnGuardarLogs);
            Controls.Add(btnDescargar);
            Controls.Add(btnSubir);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtArchivoLocal);
            Controls.Add(txtArchivoNombre);
            Controls.Add(txtFTPContraseña);
            Controls.Add(txtFTPUsuario);
            Controls.Add(txtFTPUrl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFTPUrl;
        private TextBox txtFTPUsuario;
        private TextBox txtFTPContraseña;
        private TextBox txtArchivoNombre;
        private TextBox txtArchivoLocal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSubir;
        private Button btnDescargar;
        private Button btnGuardarLogs;
        private ListBox lstLogs;
        private OpenFileDialog openFileDialog1;
        private Label label6;
    }
}
