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
            mtbPrecio.Text = "";
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
                mtbPrecio.Enabled = false;
            }
            else
            {
                mtbPrecio.Enabled = true;
            }
        }

        private void mtbPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbPrecio.Text == "")
            {
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
            }
        }
    }
}
