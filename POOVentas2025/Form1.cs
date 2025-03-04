namespace POOVentas2025
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        //Pan es el principal de todos los prodcutos(los tipos de panes)
        //Se usa el ToString para identificar que la C son los pesos y la P el porcentaje
        //El Form1_Load, cuando inice el programa se mostrará los precios de los panes
        private void Form1_Load(object sender, EventArgs e)
        {
            TxtPrecioPanFrances.Text = Pan.PrecioPanFrances.ToString("C");
            TxtPrecioBolillo.Text = Pan.PrecioBolillo.ToString("C");
            TxtInteresCupcake.Text = Pan.InteresCupcake.ToString("P0");
        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtPanFrances_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtBolillo_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtCupcake_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        //El botón de agregar, ayuda a agrergar cuantos panes son y el total de ellos
        private void Agregar_Click(object sender, EventArgs e)
        {
            Pago formaPago;
            string tipoPago;
            if (rbtnContado.Checked)
            {
                formaPago = new Contado(0);
                tipoPago = "Contado";
            }
            else if (rbtnCredito.Checked)
            {
                formaPago = new Credito(0);
                tipoPago = "Crédito";
            }
            else
            {
                MessageBox.Show("Seleccione una forma de pago c:");
                return;
            }

            if (decimal.TryParse(TxtPanFrances.Text, out decimal panFrancesCantidad) &&
                decimal.TryParse(TxtBolillo.Text, out decimal bolilloCantidad) &&
                decimal.TryParse(TxtCupcake.Text, out decimal cupcakeCantidad) &&
                decimal.TryParse(TxtPrecioPanFrances.Text.Replace("$", "").Trim(), out decimal precioPanFrances) &&
                decimal.TryParse(TxtPrecioBolillo.Text.Replace("$", "").Trim(), out decimal precioBolillo) &&
                decimal.TryParse(TxtInteresCupcake.Text.Replace("%", "").Trim(), out decimal interesCupcake))
            {
                decimal totalPanFrances = panFrancesCantidad * precioPanFrances;
                decimal totalBolillo = bolilloCantidad * precioBolillo;
                decimal totalCupcake = cupcakeCantidad * Pan.PrecioCupcake;
                decimal totalConInteresCupcake = totalCupcake + (totalCupcake * interesCupcake);

                decimal total = totalPanFrances + totalBolillo + totalConInteresCupcake;

                // Calcula el total con el tipo de pago seleccionado
                formaPago.Monto = total;
                decimal totalConPago = formaPago.CalcularTotal();

                // Agrega a la tabla
                DgvPan.Rows.Add(TxtCliente.Text, panFrancesCantidad, bolilloCantidad, cupcakeCantidad, totalConPago.ToString("F2"), tipoPago);

                if (decimal.TryParse(TxtTotal.Text, out decimal currentTotal))
                {
                    TxtTotal.Text = (currentTotal + totalConPago).ToString("F2");
                }
                else
                {
                    TxtTotal.Text = totalConPago.ToString("F2");
                }
            }
            else
            {
                MessageBox.Show("Intente de nuevo D:");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtInteresCupcake_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Se agrega el botón de restaurar para que cuando pase el Total del cliente, el siguiente no le afecte
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            TxtTotal.Clear();
        }

        private void rbtnContado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCredito_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
