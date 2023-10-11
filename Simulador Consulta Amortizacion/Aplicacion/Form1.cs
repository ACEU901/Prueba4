namespace Simulador_Consulta_Amortizacion
{
    public partial class Consulta_Amortizacion_Prestamo : Form
    {
        public Consulta_Amortizacion_Prestamo()
        {
            InitializeComponent();
            restablecer();
        }

        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            restablecer();
        }
        private void restablecer()
        {
            tb_Prestamo.Text = "";
            tb_TasaInteres.Text = "";
            tb_Plazo.Text = "";
            dgv_ConsultaAmortizacionPrestamo.Rows.Clear();
            l_ZonaMensaje.Text = "";
        }
    }
}