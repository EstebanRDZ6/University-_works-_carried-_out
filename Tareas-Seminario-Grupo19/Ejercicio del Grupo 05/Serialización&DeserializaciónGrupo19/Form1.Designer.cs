namespace Serialización_DeserializaciónGrupo19
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
            textBoxNombre = new TextBox();
            textBoxEdad = new TextBox();
            textBoxResultados = new TextBox();
            buttonAgregar = new Button();
            buttonSerializar = new Button();
            buttonDeserializar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonEliminar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(137, 56);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(137, 97);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(100, 23);
            textBoxEdad.TabIndex = 1;
            // 
            // textBoxResultados
            // 
            textBoxResultados.Location = new Point(6, 149);
            textBoxResultados.Multiline = true;
            textBoxResultados.Name = "textBoxResultados";
            textBoxResultados.ReadOnly = true;
            textBoxResultados.Size = new Size(753, 164);
            textBoxResultados.TabIndex = 2;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(255, 57);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 3;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonSerializar
            // 
            buttonSerializar.Location = new Point(255, 97);
            buttonSerializar.Name = "buttonSerializar";
            buttonSerializar.Size = new Size(75, 23);
            buttonSerializar.TabIndex = 4;
            buttonSerializar.Text = "Serializar";
            buttonSerializar.UseVisualStyleBackColor = true;
            buttonSerializar.Click += buttonSerializar_Click;
            // 
            // buttonDeserializar
            // 
            buttonDeserializar.Location = new Point(336, 97);
            buttonDeserializar.Name = "buttonDeserializar";
            buttonDeserializar.Size = new Size(79, 23);
            buttonDeserializar.TabIndex = 5;
            buttonDeserializar.Text = "Deserealizar";
            buttonDeserializar.UseVisualStyleBackColor = true;
            buttonDeserializar.Click += buttonDeserializar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 61);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 100);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 7;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Desktop;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 9);
            label3.Name = "label3";
            label3.Size = new Size(683, 30);
            label3.TabIndex = 8;
            label3.Text = "Serialización y Deserialización de un objeto Persona con el Grupo 19\r\n";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(336, 57);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 9;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 61);
            label4.Name = "label4";
            label4.Size = new Size(210, 15);
            label4.TabIndex = 10;
            label4.Text = "(Ingrese Nombre y Edad para eliminar)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(buttonEliminar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDeserializar);
            Controls.Add(buttonSerializar);
            Controls.Add(buttonAgregar);
            Controls.Add(textBoxResultados);
            Controls.Add(textBoxEdad);
            Controls.Add(textBoxNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxEdad;
        private TextBox textBoxResultados;
        private Button buttonAgregar;
        private Button buttonSerializar;
        private Button buttonDeserializar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonEliminar;
        private Label label4;
    }
}
