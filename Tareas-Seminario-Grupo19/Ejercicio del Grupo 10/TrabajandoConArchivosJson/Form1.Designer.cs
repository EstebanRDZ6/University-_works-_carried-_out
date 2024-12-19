namespace TrabajandoConArchivosJson
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
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonSerializar = new Button();
            buttonDeserializar = new Button();
            textBoxNombre = new TextBox();
            textBoxEdad = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxResultados = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            T = new Label();
            SuspendLayout();
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(261, 116);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 0;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(357, 116);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 1;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonSerializar
            // 
            buttonSerializar.Location = new Point(261, 145);
            buttonSerializar.Name = "buttonSerializar";
            buttonSerializar.Size = new Size(75, 23);
            buttonSerializar.TabIndex = 2;
            buttonSerializar.Text = "Serializar";
            buttonSerializar.UseVisualStyleBackColor = true;
            buttonSerializar.Click += buttonSerializar_Click;
            // 
            // buttonDeserializar
            // 
            buttonDeserializar.Location = new Point(357, 145);
            buttonDeserializar.Name = "buttonDeserializar";
            buttonDeserializar.Size = new Size(75, 23);
            buttonDeserializar.TabIndex = 3;
            buttonDeserializar.Text = "Deserializar";
            buttonDeserializar.UseVisualStyleBackColor = true;
            buttonDeserializar.Click += buttonDeserializar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(137, 102);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(137, 131);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(100, 23);
            textBoxEdad.TabIndex = 5;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(137, 160);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(100, 23);
            textBoxCorreo.TabIndex = 6;
            // 
            // textBoxResultados
            // 
            textBoxResultados.Location = new Point(12, 188);
            textBoxResultados.Multiline = true;
            textBoxResultados.Name = "textBoxResultados";
            textBoxResultados.ReadOnly = true;
            textBoxResultados.Size = new Size(715, 148);
            textBoxResultados.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 105);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 134);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 9;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 163);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 10;
            label3.Text = "Correo";
            // 
            // T
            // 
            T.AutoSize = true;
            T.BackColor = SystemColors.Desktop;
            T.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            T.Location = new Point(12, 27);
            T.Name = "T";
            T.Size = new Size(778, 37);
            T.TabIndex = 11;
            T.Text = "Serializando y Deserializando Archivos.Json con el Grupo19";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(T);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxResultados);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxEdad);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonDeserializar);
            Controls.Add(buttonSerializar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAgregar;
        private Button buttonEliminar;
        private Button buttonSerializar;
        private Button buttonDeserializar;
        private TextBox textBoxNombre;
        private TextBox textBoxEdad;
        private TextBox textBoxCorreo;
        private TextBox textBoxResultados;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label T;
    }
}
