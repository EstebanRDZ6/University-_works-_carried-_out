namespace ClimaConElGrupo19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxCiudad = new TextBox();
            buttonConsultar = new Button();
            labelCiudad = new Label();
            labelTemperatura = new Label();
            labelHumedad = new Label();
            labelSensacionTermica = new Label();
            labelViento = new Label();
            Titulo = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxCiudad
            // 
            textBoxCiudad.Location = new Point(480, 81);
            textBoxCiudad.Name = "textBoxCiudad";
            textBoxCiudad.Size = new Size(100, 23);
            textBoxCiudad.TabIndex = 0;
            // 
            // buttonConsultar
            // 
            buttonConsultar.BackColor = SystemColors.ActiveCaption;
            buttonConsultar.Location = new Point(586, 80);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(75, 23);
            buttonConsultar.TabIndex = 1;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = false;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // labelCiudad
            // 
            labelCiudad.AutoSize = true;
            labelCiudad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCiudad.Location = new Point(480, 127);
            labelCiudad.Name = "labelCiudad";
            labelCiudad.Size = new Size(40, 15);
            labelCiudad.TabIndex = 2;
            labelCiudad.Text = "label1";
            labelCiudad.Visible = false;
            // 
            // labelTemperatura
            // 
            labelTemperatura.AutoSize = true;
            labelTemperatura.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTemperatura.Location = new Point(480, 160);
            labelTemperatura.Name = "labelTemperatura";
            labelTemperatura.Size = new Size(40, 15);
            labelTemperatura.TabIndex = 3;
            labelTemperatura.Text = "label1";
            labelTemperatura.Visible = false;
            // 
            // labelHumedad
            // 
            labelHumedad.AutoSize = true;
            labelHumedad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelHumedad.Location = new Point(480, 222);
            labelHumedad.Name = "labelHumedad";
            labelHumedad.Size = new Size(40, 15);
            labelHumedad.TabIndex = 4;
            labelHumedad.Text = "label1";
            labelHumedad.Visible = false;
            // 
            // labelSensacionTermica
            // 
            labelSensacionTermica.AutoSize = true;
            labelSensacionTermica.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSensacionTermica.Location = new Point(480, 249);
            labelSensacionTermica.Name = "labelSensacionTermica";
            labelSensacionTermica.Size = new Size(40, 15);
            labelSensacionTermica.TabIndex = 5;
            labelSensacionTermica.Text = "label1";
            labelSensacionTermica.Visible = false;
            // 
            // labelViento
            // 
            labelViento.AutoSize = true;
            labelViento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelViento.Location = new Point(480, 189);
            labelViento.Name = "labelViento";
            labelViento.Size = new Size(40, 15);
            labelViento.TabIndex = 6;
            labelViento.Text = "label1";
            labelViento.Visible = false;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(181, 81);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(293, 21);
            Titulo.TabIndex = 7;
            Titulo.Text = "Ingrese la Ciudad para consultar el clima:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 9);
            label1.Name = "label1";
            label1.Size = new Size(485, 50);
            label1.TabIndex = 8;
            label1.Text = "Pronóstico con el Grupo19";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(171, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Titulo);
            Controls.Add(labelViento);
            Controls.Add(labelSensacionTermica);
            Controls.Add(labelHumedad);
            Controls.Add(labelTemperatura);
            Controls.Add(labelCiudad);
            Controls.Add(buttonConsultar);
            Controls.Add(textBoxCiudad);
            Name = "Form1";
            Text = "ClimaConElGrupo19";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCiudad;
        private Button buttonConsultar;
        private Label labelCiudad;
        private Label labelTemperatura;
        private Label labelHumedad;
        private Label labelSensacionTermica;
        private Label labelViento;
        private Label Titulo;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
