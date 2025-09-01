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
            txtProducto = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            btnRegistrar = new Button();
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
            dtpFecha.Location = new Point(206, 31);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 4;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(206, 77);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(200, 23);
            txtProducto.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(206, 123);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(200, 23);
            txtCantidad.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(206, 175);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(200, 23);
            txtPrecio.TabIndex = 7;
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
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 298);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
            Controls.Add(dtpFecha);
            Controls.Add(lblPrecioo);
            Controls.Add(lblCantidad);
            Controls.Add(lblProductoo);
            Controls.Add(lblFechaa);
            Name = "frmPrincipal";
            Text = "App Registro de Ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaa;
        private Label lblProductoo;
        private Label lblCantidad;
        private Label lblPrecioo;
        private DateTimePicker dtpFecha;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Button btnRegistrar;
    }
}
