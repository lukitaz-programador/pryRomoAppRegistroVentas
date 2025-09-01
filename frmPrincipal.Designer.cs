namespace pryRomoAppRegVta
{
    partial class frmPrincipal
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
            lblFechaa = new Label();
            lblProductoo = new Label();
            lblCantidad = new Label();
            lblPrecioo = new Label();
            dtpFecha = new DateTimePicker();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            nudCantidad = new NumericUpDown();
            cboProducto = new ComboBox();
            mtbPrecio = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFechaa
            // 
            lblFechaa.AutoSize = true;
            lblFechaa.Font = new Font("Segoe UI", 12F);
            lblFechaa.Location = new Point(36, 33);
            lblFechaa.Name = "lblFechaa";
            lblFechaa.Size = new Size(53, 21);
            lblFechaa.TabIndex = 0;
            lblFechaa.Text = "Fecha:";
            // 
            // lblProductoo
            // 
            lblProductoo.AutoSize = true;
            lblProductoo.Font = new Font("Segoe UI", 12F);
            lblProductoo.Location = new Point(36, 79);
            lblProductoo.Name = "lblProductoo";
            lblProductoo.Size = new Size(76, 21);
            lblProductoo.TabIndex = 1;
            lblProductoo.Text = "Producto:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F);
            lblCantidad.Location = new Point(37, 125);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(75, 21);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecioo
            // 
            lblPrecioo.AutoSize = true;
            lblPrecioo.Font = new Font("Segoe UI", 12F);
            lblPrecioo.Location = new Point(37, 177);
            lblPrecioo.Name = "lblPrecioo";
            lblPrecioo.Size = new Size(116, 21);
            lblPrecioo.TabIndex = 3;
            lblPrecioo.Text = "Precio Unitario:";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 9F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(206, 31);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(368, 235);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(82, 32);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(269, 235);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 32);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Location = new Point(206, 125);
            nudCantidad.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(100, 23);
            nudCantidad.TabIndex = 10;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(206, 77);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(200, 23);
            cboProducto.TabIndex = 12;
            cboProducto.TextChanged += cboProducto_TextChanged;
            // 
            // mtbPrecio
            // 
            mtbPrecio.Location = new Point(206, 175);
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(100, 23);
            mtbPrecio.TabIndex = 13;
            mtbPrecio.MaskInputRejected += mtbPrecio_MaskInputRejected;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 298);
            Controls.Add(mtbPrecio);
            Controls.Add(cboProducto);
            Controls.Add(nudCantidad);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(dtpFecha);
            Controls.Add(lblPrecioo);
            Controls.Add(lblCantidad);
            Controls.Add(lblProductoo);
            Controls.Add(lblFechaa);
            Name = "frmPrincipal";
            Text = "App Registro de Ventas";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaa;
        private Label lblProductoo;
        private Label lblCantidad;
        private Label lblPrecioo;
        private DateTimePicker dtpFecha;
        private Button btnRegistrar;
        private Button btnCancelar;
        private NumericUpDown nudCantidad;
        private ComboBox cboProducto;
        private MaskedTextBox mtbPrecio;
    }
}
