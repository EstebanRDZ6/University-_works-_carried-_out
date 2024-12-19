namespace ARCHIVOS_DATOS__ESTRUCTURAS_DE_REGISTROS_
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
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtAño = new TextBox();
            txtColor = new TextBox();
            txtNumeroSerie = new TextBox();
            btnGuardar = new Button();
            btnCargar = new Button();
            btnEliminar = new Button();
            txtMostrar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(168, 140);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 0;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(168, 111);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 1;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(168, 169);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 2;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(168, 198);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 3;
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.Location = new Point(168, 227);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(100, 23);
            txtNumeroSerie.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(193, 263);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(295, 263);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 6;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(389, 263);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button3_Click;
            // 
            // txtMostrar
            // 
            txtMostrar.Location = new Point(12, 292);
            txtMostrar.Multiline = true;
            txtMostrar.Name = "txtMostrar";
            txtMostrar.ReadOnly = true;
            txtMostrar.Size = new Size(717, 146);
            txtMostrar.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 143);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 9;
            label1.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 177);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 10;
            label2.Text = "Año:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 111);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 11;
            label3.Text = "Modelo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 206);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 12;
            label4.Text = "Color:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 235);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 13;
            label5.Text = "Número de Serie:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Desktop;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(168, 23);
            label6.Name = "label6";
            label6.Size = new Size(435, 37);
            label6.TabIndex = 14;
            label6.Text = "Gestor de Vehiculos del Grupo19";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMostrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCargar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNumeroSerie);
            Controls.Add(txtColor);
            Controls.Add(txtAño);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtAño;
        private TextBox txtColor;
        private TextBox txtNumeroSerie;
        private Button btnGuardar;
        private Button btnCargar;
        private Button btnEliminar;
        private TextBox txtMostrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
