namespace GestionandoVehiculosConElGrupo19
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
            txtNombreDueno = new TextBox();
            txtAno = new TextBox();
            txtMarca = new TextBox();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            cmbTipoVehiculo = new ComboBox();
            btnAgregar = new Button();
            lstVehiculos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonEliminar = new Button();
            SuspendLayout();
            // 
            // txtNombreDueno
            // 
            txtNombreDueno.Location = new Point(129, 145);
            txtNombreDueno.Name = "txtNombreDueno";
            txtNombreDueno.Size = new Size(100, 23);
            txtNombreDueno.TabIndex = 0;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(284, 145);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 1;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(284, 185);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(129, 185);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(129, 235);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Items.AddRange(new object[] { "Auto", "Moto" });
            cmbTipoVehiculo.Location = new Point(129, 100);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(121, 23);
            cmbTipoVehiculo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(246, 238);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(3, 278);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(795, 169);
            lstVehiculos.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 148);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre del Dueño:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 153);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 9;
            label2.Text = "Año:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 190);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 10;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 190);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 11;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 238);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 12;
            label5.Text = "Descripción:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 103);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 13;
            label6.Text = "Tipo de Vehiculo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Desktop;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(129, 22);
            label7.Name = "label7";
            label7.Size = new Size(466, 40);
            label7.TabIndex = 14;
            label7.Text = "Gestor de Vehiculos del Grupo19";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(327, 238);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 15;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEliminar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstVehiculos);
            Controls.Add(btnAgregar);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtPrecio);
            Controls.Add(txtMarca);
            Controls.Add(txtAno);
            Controls.Add(txtNombreDueno);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreDueno;
        private TextBox txtAno;
        private TextBox txtMarca;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private ComboBox cmbTipoVehiculo;
        private Button btnAgregar;
        private ListBox lstVehiculos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonEliminar;
    }
}
