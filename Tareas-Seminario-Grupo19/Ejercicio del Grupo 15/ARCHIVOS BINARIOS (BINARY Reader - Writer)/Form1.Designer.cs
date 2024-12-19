namespace ARCHIVOS_BINARIOS__BINARY_Reader___Writer_
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
            btnGuardar = new Button();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            txtTelefono = new TextBox();
            Alumno = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstAlumnos = new ListBox();
            btnCargar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(162, 236);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(190, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(190, 151);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(190, 197);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 3;
            // 
            // Alumno
            // 
            Alumno.AutoSize = true;
            Alumno.BackColor = SystemColors.Desktop;
            Alumno.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Alumno.Location = new Point(137, 19);
            Alumno.Name = "Alumno";
            Alumno.Size = new Size(459, 40);
            Alumno.TabIndex = 4;
            Alumno.Text = "Gestor de Alumnos del Grupo19";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 115);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 159);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 6;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 200);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefono:";
            // 
            // lstAlumnos
            // 
            lstAlumnos.FormattingEnabled = true;
            lstAlumnos.ItemHeight = 15;
            lstAlumnos.Location = new Point(12, 265);
            lstAlumnos.Name = "lstAlumnos";
            lstAlumnos.Size = new Size(744, 169);
            lstAlumnos.TabIndex = 8;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(243, 236);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 9;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(324, 236);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnCargar);
            Controls.Add(lstAlumnos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Alumno);
            Controls.Add(txtTelefono);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox txtTelefono;
        private Label Alumno;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstAlumnos;
        private Button btnCargar;
        private Button btnEliminar;
    }
}
