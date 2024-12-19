namespace Aeropuerto19
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
            Titulo = new Label();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            dataGridViewAviones = new DataGridView();
            ID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            textBoxId = new TextBox();
            textBoxModelo = new TextBox();
            textBoxMatricula = new TextBox();
            textBoxTipoDeNave = new TextBox();
            textBoxCapacidadPasajeros = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAviones).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = SystemColors.Desktop;
            Titulo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(184, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(266, 50);
            Titulo.TabIndex = 0;
            Titulo.Text = "Aeropuerto19";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(184, 180);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(278, 180);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 2;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(369, 180);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 3;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // dataGridViewAviones
            // 
            dataGridViewAviones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAviones.Location = new Point(110, 209);
            dataGridViewAviones.Name = "dataGridViewAviones";
            dataGridViewAviones.Size = new Size(409, 209);
            dataGridViewAviones.TabIndex = 4;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(184, 78);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 5;
            ID.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 78);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 6;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 113);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 7;
            label3.Text = "Tipo de Nave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 117);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Matrícula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 148);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 9;
            label1.Text = "Capacidad de Pasajeros";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(208, 75);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 10;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(390, 75);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(100, 23);
            textBoxModelo.TabIndex = 11;
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(208, 113);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(100, 23);
            textBoxMatricula.TabIndex = 12;
            // 
            // textBoxTipoDeNave
            // 
            textBoxTipoDeNave.Location = new Point(390, 109);
            textBoxTipoDeNave.Name = "textBoxTipoDeNave";
            textBoxTipoDeNave.Size = new Size(100, 23);
            textBoxTipoDeNave.TabIndex = 13;
            // 
            // textBoxCapacidadPasajeros
            // 
            textBoxCapacidadPasajeros.Location = new Point(328, 145);
            textBoxCapacidadPasajeros.Name = "textBoxCapacidadPasajeros";
            textBoxCapacidadPasajeros.Size = new Size(100, 23);
            textBoxCapacidadPasajeros.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(450, 173);
            label5.Name = "label5";
            label5.Size = new Size(293, 30);
            label5.TabIndex = 15;
            label5.Text = "(Ingrese la ID del avión a Modificar y los datos nuevos)\r\n(Para Eliminar Ingrese la ID del avión a Eliminar)\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(label5);
            Controls.Add(textBoxCapacidadPasajeros);
            Controls.Add(textBoxTipoDeNave);
            Controls.Add(textBoxMatricula);
            Controls.Add(textBoxModelo);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ID);
            Controls.Add(dataGridViewAviones);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAgregar);
            Controls.Add(Titulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAviones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Button buttonAgregar;
        private Button buttonModificar;
        private Button buttonEliminar;
        private DataGridView dataGridViewAviones;
        private Label ID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox textBoxId;
        private TextBox textBoxModelo;
        private TextBox textBoxMatricula;
        private TextBox textBoxTipoDeNave;
        private TextBox textBoxCapacidadPasajeros;
        private Label label5;
    }
}
