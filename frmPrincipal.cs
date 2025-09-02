namespace pryRomoAppRegVta
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        DateTime vFecha = DateTime.Now;
        string vProducto;
        int vCantidad;
        int vPrecio;
        int vPrecioFinal;


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nudCantidad.Text = "";
            cboProducto.SelectedIndex=-1;
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            cboProducto.Items.Add("CPU");
            cboProducto.Items.Add("RAM");
            cboProducto.Items.Add("GPU");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vFecha = dtpFecha.Value;
            vProducto = cboProducto.Text;
            vCantidad = Convert.ToInt32(nudCantidad.Value);
            vPrecio = Convert.ToInt32(mtbPrecio.Text);
            vPrecioFinal = vPrecio * vCantidad;

            lblResultadosRegistro.Text =
                vFecha + " " + vProducto
                + " " + vCantidad + " $" + vPrecioFinal + "\n";
        }

        private void mtbPrecio_TextChanged(object sender, EventArgs e)
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
