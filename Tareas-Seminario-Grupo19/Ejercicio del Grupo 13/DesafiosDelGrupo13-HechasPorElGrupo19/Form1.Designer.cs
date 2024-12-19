namespace DesafiosDelGrupo13_HechasPorElGrupo19
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
            label1 = new Label();
            Listas = new Label();
            textBoxNumero = new TextBox();
            textBoxPosicion = new TextBox();
            textBoxNumeroCola = new TextBox();
            textBoxNumeroPila = new TextBox();
            listBoxLista = new ListBox();
            listBoxCola = new ListBox();
            listBoxPila = new ListBox();
            label2 = new Label();
            label3 = new Label();
            buttonInsertar = new Button();
            buttonModificar = new Button();
            buttonEliminarLista = new Button();
            buttonOrdenarLista = new Button();
            label4 = new Label();
            label5 = new Label();
            buttonAñadirCola = new Button();
            buttonEliminarCola = new Button();
            buttonMostrarCola = new Button();
            label6 = new Label();
            buttonApilar = new Button();
            buttonDesapilar = new Button();
            buttonMostrarPila = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(178, 9);
            label1.Name = "label1";
            label1.Size = new Size(463, 37);
            label1.TabIndex = 0;
            label1.Text = "Listas, Pilas y Colas con el Grupo19";
            // 
            // Listas
            // 
            Listas.AutoSize = true;
            Listas.BackColor = SystemColors.Desktop;
            Listas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Listas.Location = new Point(117, 74);
            Listas.Name = "Listas";
            Listas.Size = new Size(37, 15);
            Listas.TabIndex = 1;
            Listas.Text = "Listas";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(98, 114);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(100, 23);
            textBoxNumero.TabIndex = 2;
            // 
            // textBoxPosicion
            // 
            textBoxPosicion.Location = new Point(98, 143);
            textBoxPosicion.Name = "textBoxPosicion";
            textBoxPosicion.Size = new Size(100, 23);
            textBoxPosicion.TabIndex = 3;
            // 
            // textBoxNumeroCola
            // 
            textBoxNumeroCola.Location = new Point(358, 119);
            textBoxNumeroCola.Name = "textBoxNumeroCola";
            textBoxNumeroCola.Size = new Size(100, 23);
            textBoxNumeroCola.TabIndex = 4;
            // 
            // textBoxNumeroPila
            // 
            textBoxNumeroPila.Location = new Point(632, 119);
            textBoxNumeroPila.Name = "textBoxNumeroPila";
            textBoxNumeroPila.Size = new Size(100, 23);
            textBoxNumeroPila.TabIndex = 5;
            // 
            // listBoxLista
            // 
            listBoxLista.FormattingEnabled = true;
            listBoxLista.ItemHeight = 15;
            listBoxLista.Location = new Point(48, 239);
            listBoxLista.Name = "listBoxLista";
            listBoxLista.Size = new Size(156, 94);
            listBoxLista.TabIndex = 6;
            // 
            // listBoxCola
            // 
            listBoxCola.FormattingEnabled = true;
            listBoxCola.ItemHeight = 15;
            listBoxCola.Location = new Point(302, 206);
            listBoxCola.Name = "listBoxCola";
            listBoxCola.Size = new Size(156, 94);
            listBoxCola.TabIndex = 7;
            // 
            // listBoxPila
            // 
            listBoxPila.FormattingEnabled = true;
            listBoxPila.ItemHeight = 15;
            listBoxPila.Location = new Point(581, 209);
            listBoxPila.Name = "listBoxPila";
            listBoxPila.Size = new Size(168, 94);
            listBoxPila.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Desktop;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(383, 74);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 9;
            label2.Text = "Colas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Desktop;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(662, 74);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 10;
            label3.Text = "Pilas";
            // 
            // buttonInsertar
            // 
            buttonInsertar.Location = new Point(48, 181);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(75, 23);
            buttonInsertar.TabIndex = 11;
            buttonInsertar.Text = "Insertar";
            buttonInsertar.UseVisualStyleBackColor = true;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(129, 181);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 12;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminarLista
            // 
            buttonEliminarLista.Location = new Point(48, 210);
            buttonEliminarLista.Name = "buttonEliminarLista";
            buttonEliminarLista.Size = new Size(75, 23);
            buttonEliminarLista.TabIndex = 13;
            buttonEliminarLista.Text = "Eliminar";
            buttonEliminarLista.UseVisualStyleBackColor = true;
            buttonEliminarLista.Click += buttonEliminarLista_Click;
            // 
            // buttonOrdenarLista
            // 
            buttonOrdenarLista.Location = new Point(129, 210);
            buttonOrdenarLista.Name = "buttonOrdenarLista";
            buttonOrdenarLista.Size = new Size(75, 23);
            buttonOrdenarLista.TabIndex = 14;
            buttonOrdenarLista.Text = "Ordenar";
            buttonOrdenarLista.UseVisualStyleBackColor = true;
            buttonOrdenarLista.Click += buttonOrdenarLista_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 117);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 15;
            label4.Text = "Ingrese número";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 146);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 16;
            label5.Text = "Ingrese posición";
            // 
            // buttonAñadirCola
            // 
            buttonAñadirCola.Location = new Point(383, 148);
            buttonAñadirCola.Name = "buttonAñadirCola";
            buttonAñadirCola.Size = new Size(75, 23);
            buttonAñadirCola.TabIndex = 17;
            buttonAñadirCola.Text = "Añadir";
            buttonAñadirCola.UseVisualStyleBackColor = true;
            buttonAñadirCola.Click += buttonAñadirCola_Click;
            // 
            // buttonEliminarCola
            // 
            buttonEliminarCola.Location = new Point(302, 148);
            buttonEliminarCola.Name = "buttonEliminarCola";
            buttonEliminarCola.Size = new Size(75, 23);
            buttonEliminarCola.TabIndex = 18;
            buttonEliminarCola.Text = "Eliminar";
            buttonEliminarCola.UseVisualStyleBackColor = true;
            buttonEliminarCola.Click += buttonEliminarCola_Click;
            // 
            // buttonMostrarCola
            // 
            buttonMostrarCola.Location = new Point(349, 177);
            buttonMostrarCola.Name = "buttonMostrarCola";
            buttonMostrarCola.Size = new Size(75, 23);
            buttonMostrarCola.TabIndex = 19;
            buttonMostrarCola.Text = "Mostrar";
            buttonMostrarCola.UseVisualStyleBackColor = true;
            buttonMostrarCola.Click += buttonMostrarCola_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 122);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 20;
            label6.Text = "Ingrese número";
            // 
            // buttonApilar
            // 
            buttonApilar.Location = new Point(593, 152);
            buttonApilar.Name = "buttonApilar";
            buttonApilar.Size = new Size(75, 23);
            buttonApilar.TabIndex = 21;
            buttonApilar.Text = "Apilar";
            buttonApilar.UseVisualStyleBackColor = true;
            buttonApilar.Click += buttonApilar_Click;
            // 
            // buttonDesapilar
            // 
            buttonDesapilar.Location = new Point(674, 151);
            buttonDesapilar.Name = "buttonDesapilar";
            buttonDesapilar.Size = new Size(75, 23);
            buttonDesapilar.TabIndex = 22;
            buttonDesapilar.Text = "Desapilar";
            buttonDesapilar.UseVisualStyleBackColor = true;
            buttonDesapilar.Click += buttonDesapilar_Click;
            // 
            // buttonMostrarPila
            // 
            buttonMostrarPila.Location = new Point(630, 180);
            buttonMostrarPila.Name = "buttonMostrarPila";
            buttonMostrarPila.Size = new Size(75, 23);
            buttonMostrarPila.TabIndex = 23;
            buttonMostrarPila.Text = "Mostrar";
            buttonMostrarPila.UseVisualStyleBackColor = true;
            buttonMostrarPila.Click += buttonMostrarPila_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(536, 122);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 24;
            label7.Text = "Ingrese número";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(buttonMostrarPila);
            Controls.Add(buttonDesapilar);
            Controls.Add(buttonApilar);
            Controls.Add(label6);
            Controls.Add(buttonMostrarCola);
            Controls.Add(buttonEliminarCola);
            Controls.Add(buttonAñadirCola);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonOrdenarLista);
            Controls.Add(buttonEliminarLista);
            Controls.Add(buttonModificar);
            Controls.Add(buttonInsertar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxPila);
            Controls.Add(listBoxCola);
            Controls.Add(listBoxLista);
            Controls.Add(textBoxNumeroPila);
            Controls.Add(textBoxNumeroCola);
            Controls.Add(textBoxPosicion);
            Controls.Add(textBoxNumero);
            Controls.Add(Listas);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Listas;
        private TextBox textBoxNumero;
        private TextBox textBoxPosicion;
        private TextBox textBoxNumeroCola;
        private TextBox textBoxNumeroPila;
        private ListBox listBoxLista;
        private ListBox listBoxCola;
        private ListBox listBoxPila;
        private Label label2;
        private Label label3;
        private Button buttonInsertar;
        private Button buttonModificar;
        private Button buttonEliminarLista;
        private Button buttonOrdenarLista;
        private Label label4;
        private Label label5;
        private Button buttonAñadirCola;
        private Button buttonEliminarCola;
        private Button buttonMostrarCola;
        private Label label6;
        private Button buttonApilar;
        private Button buttonDesapilar;
        private Button buttonMostrarPila;
        private Label label7;
    }
}
