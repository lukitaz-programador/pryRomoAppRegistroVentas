namespace pryRomoAppRegVta
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nudCantidad.Text = "";
            cboProducto.Text = "";
            nudPrecio.Text = "";
        }



        private void nudPrecio_ValueChanged(object sender, EventArgs e)
        {
            if (nudPrecio.Value == 0)
            {
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
            }
        }

        private void cboProducto_TextChanged(object sender, EventArgs e)
        {
            if (cboProducto.Text == "")
            {
                nudCantidad.Enabled = false;
            }
            else
            {
                nudCantidad.Enabled = true;
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Value == 0)
            {
                nudPrecio.Enabled = false;
            }
            else
            {
                nudPrecio.Enabled = true;
            }
        }

        private void mtbPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
