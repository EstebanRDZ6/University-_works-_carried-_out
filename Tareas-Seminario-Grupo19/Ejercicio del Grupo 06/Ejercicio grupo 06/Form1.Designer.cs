namespace Ejercicio_grupo_06__DLL
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
            comboBoxFiguras = new ComboBox();
            textBoxParam1 = new TextBox();
            textBoxParam2 = new TextBox();
            BtnCalcular = new Button();
            labelResultado = new Label();
            Consigna = new Label();
            Result = new Label();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = SystemColors.Highlight;
            Titulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(3, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(712, 37);
            Titulo.TabIndex = 0;
            Titulo.Text = "Calculador de áreas de diferentes Figuras Geométricas";
            // 
            // comboBoxFiguras
            // 
            comboBoxFiguras.FormattingEnabled = true;
            comboBoxFiguras.Location = new Point(184, 59);
            comboBoxFiguras.Name = "comboBoxFiguras";
            comboBoxFiguras.Size = new Size(121, 23);
            comboBoxFiguras.TabIndex = 1;
            comboBoxFiguras.SelectedIndexChanged += comboBoxFiguras_SelectedIndexChanged;
            // 
            // textBoxParam1
            // 
            textBoxParam1.Location = new Point(184, 88);
            textBoxParam1.Name = "textBoxParam1";
            textBoxParam1.Size = new Size(121, 23);
            textBoxParam1.TabIndex = 2;
            // 
            // textBoxParam2
            // 
            textBoxParam2.Location = new Point(184, 117);
            textBoxParam2.Name = "textBoxParam2";
            textBoxParam2.Size = new Size(121, 23);
            textBoxParam2.TabIndex = 3;
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = SystemColors.ActiveCaption;
            BtnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            BtnCalcular.Location = new Point(312, 88);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(71, 25);
            BtnCalcular.TabIndex = 4;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(489, 93);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(38, 15);
            labelResultado.TabIndex = 5;
            labelResultado.Text = "label1";
            // 
            // Consigna
            // 
            Consigna.AutoSize = true;
            Consigna.BackColor = SystemColors.ActiveCaption;
            Consigna.Location = new Point(12, 62);
            Consigna.Name = "Consigna";
            Consigna.Size = new Size(166, 15);
            Consigna.TabIndex = 6;
            Consigna.Text = "Seleccione Figura Geométrica:";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(390, 93);
            Result.Name = "Result";
            Result.Size = new Size(93, 15);
            Result.TabIndex = 7;
            Result.Text = "El Resultado es=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 450);
            Controls.Add(Result);
            Controls.Add(Consigna);
            Controls.Add(labelResultado);
            Controls.Add(BtnCalcular);
            Controls.Add(textBoxParam2);
            Controls.Add(textBoxParam1);
            Controls.Add(comboBoxFiguras);
            Controls.Add(Titulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private ComboBox comboBoxFiguras;
        private TextBox textBoxParam1;
        private TextBox textBoxParam2;
        private Button BtnCalcular;
        private Label labelResultado;
        private Label Consigna;
        private Label Result;
    }
}
