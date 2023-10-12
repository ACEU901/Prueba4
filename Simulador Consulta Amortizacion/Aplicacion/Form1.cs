using Consulta_Amortizacion_Prestamo.Libreria;
using Simulador_Consulta_Amortizacion.Libreria;

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
            l_ZonaMensajes.Text = "";
        }

        private void dgv_ConsultaAmortizacionPrestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_Consultar_Click(object sender, EventArgs e)
        {
            ValidaDatos objVD = new ValidaDatos();
            l_ZonaMensajes.Text = objVD.esEntero("Valor Prestamo", tb_Prestamo.Text);
            if ("".Equals(l_ZonaMensajes.Text))
            {
                l_ZonaMensajes.Text = objVD.esRealCorto("Valor Tasa-Interes", tb_TasaInteres.Text);
                if ("".Equals(l_ZonaMensajes.Text))
                {
                    l_ZonaMensajes.Text = objVD.esEntero("Valor Plazo", tb_Plazo.Text);
                    if ("".Equals(l_ZonaMensajes.Text))
                    {
                        // Validación OK
                        int monto = int.Parse(tb_Prestamo.Text);
                        float tasaInteres = float.Parse(tb_TasaInteres.Text);
                        int plazo = int.Parse(tb_Plazo.Text);
                        dgv_ConsultaAmortizacionPrestamo.Rows.Clear();

                        Prestamo prestamo = new Prestamo(monto, tasaInteres, plazo);

                        Amortizacion amortizacion = new Amortizacion();
                        int[][] tablaAmortizacion = amortizacion.obtenerAmortizacion(prestamo);

                        for (int i = 0; i < tablaAmortizacion.Length; i++)
                        {
                            dgv_ConsultaAmortizacionPrestamo.Rows.Add(
                                tablaAmortizacion[i][0], // Periodo
                                 string.Format("{0:n0}", tablaAmortizacion[i][1]), // Cuota con separadores de miles
                                 string.Format("{0:n0}", tablaAmortizacion[i][2]), // Interes con separadores de miles
                                 string.Format("{0:n0}", tablaAmortizacion[i][3]), // Amortización con separadores de miles
                                 string.Format("{0:n0}", tablaAmortizacion[i][4])  // Prestamo con separadores de miles
                            );
                        }

                    }
                    else
                    {
                        tb_Plazo.SelectAll();
                        tb_Plazo.Focus();
                    }
                }
                else
                {
                    tb_TasaInteres.SelectAll();
                    tb_TasaInteres.Focus();
                }
            }
            else
            {
                tb_Prestamo.SelectAll();
                tb_Prestamo.Focus();
            }
        }


    }
}