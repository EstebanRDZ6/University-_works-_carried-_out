﻿namespace C2_110924
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
            label2 = new Label();
            txtNombre = new TextBox();
            groupBox1 = new GroupBox();
            btnModificar = new Button();
            cbxTipoMovimiento = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            nupCantidadMovimineto = new NumericUpDown();
            lstProductos = new ListBox();
            label4 = new Label();
            btnAgregar = new Button();
            btnRecargar = new Button();
            txtID = new TextBox();
            label7 = new Label();
            btnEliminarProducto = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidadMovimineto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 0;
            label1.Text = "Gestión de productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 153);
            label2.Name = "label2";
            label2.Size = new Size(163, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre del producto:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(265, 145);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(246, 29);
            txtNombre.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(cbxTipoMovimiento);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nupCantidadMovimineto);
            groupBox1.Location = new Point(15, 431);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 145);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de movimientos";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(560, 40);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(190, 42);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar stock";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // cbxTipoMovimiento
            // 
            cbxTipoMovimiento.FormattingEnabled = true;
            cbxTipoMovimiento.Items.AddRange(new object[] { "AGREGAR", "QUITAR" });
            cbxTipoMovimiento.Location = new Point(228, 88);
            cbxTipoMovimiento.Name = "cbxTipoMovimiento";
            cbxTipoMovimiento.Size = new Size(150, 29);
            cbxTipoMovimiento.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 91);
            label6.Name = "label6";
            label6.Size = new Size(131, 21);
            label6.TabIndex = 10;
            label6.Text = "Tipo movimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 47);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 9;
            label5.Text = "Cantidad:";
            // 
            // nupCantidadMovimineto
            // 
            nupCantidadMovimineto.Location = new Point(228, 45);
            nupCantidadMovimineto.Name = "nupCantidadMovimineto";
            nupCantidadMovimineto.Size = new Size(150, 29);
            nupCantidadMovimineto.TabIndex = 0;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 21;
            lstProductos.Location = new Point(13, 282);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(498, 130);
            lstProductos.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 239);
            label4.Name = "label4";
            label4.Size = new Size(158, 21);
            label4.TabIndex = 7;
            label4.Text = "Listado de productos:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(575, 101);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(190, 42);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(512, 12);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(284, 42);
            btnRecargar.TabIndex = 9;
            btnRecargar.Text = "Recargar productos";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(266, 105);
            txtID.Name = "txtID";
            txtID.Size = new Size(246, 29);
            txtID.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 108);
            label7.Name = "label7";
            label7.Size = new Size(120, 21);
            label7.TabIndex = 10;
            label7.Text = "ID del producto:";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(575, 185);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(190, 40);
            btnEliminarProducto.TabIndex = 12;
            btnEliminarProducto.Text = "Eliminar producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(823, 615);
            Controls.Add(btnEliminarProducto);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(btnRecargar);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(lstProductos);
            Controls.Add(groupBox1);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidadMovimineto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private Button btnModificar;
        private ComboBox cbxTipoMovimiento;
        private Label label6;
        private Label label5;
        private NumericUpDown nupCantidadMovimineto;
        private ListBox lstProductos;
        private Label label4;
        private Button btnAgregar;
        private Button btnRecargar;
        private TextBox txtID;
        private Label label7;
        private Button btnEliminarProducto;
    }
}
