namespace pryRomoAppRegVta
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Text=="" || txtCantidad.Text==""||txtPrecio.Text==""||txtProducto.Text=="" )
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
