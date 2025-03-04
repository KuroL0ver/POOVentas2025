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
            //Se usa el Try Parse para una cadena de texto en valor decimal, y el usuario no pone un número en el TxtBox, para que no se caiga el programa
            //los && es para que se cumpla lo que el usuario puso en los TxtBox
            //El Trim se puso para que no tengan espacios en blanco
            //Lo que es del signo de pesos y porcentaje se puso para que no afecte en el programa a la hora de ejecutarlo
            if (decimal.TryParse(TxtPanFrances.Text, out decimal panFrancesCantidad) &&
                decimal.TryParse(TxtBolillo.Text, out decimal bolilloCantidad) &&
                decimal.TryParse(TxtCupcake.Text, out decimal cupcakeCantidad) &&
                decimal.TryParse(TxtPrecioPanFrances.Text.Replace("$", "").Trim(), out decimal precioPanFrances) &&
                decimal.TryParse(TxtPrecioBolillo.Text.Replace("$", "").Trim(), out decimal precioBolillo) &&
                decimal.TryParse(TxtInteresCupcake.Text.Replace("%", "").Trim(), out decimal interesCupcake))
            {
                //Se multiplica los panes por la cantidad
                decimal totalPanFrances = panFrancesCantidad * precioPanFrances;
                decimal totalBolillo = bolilloCantidad * precioBolillo;
                decimal totalCupcake = cupcakeCantidad * Pan.PrecioCupcake;
                decimal totalConInteresCupcake = totalCupcake + (totalCupcake * interesCupcake);

                //Suma total de todo
                decimal total = totalPanFrances + totalBolillo + totalConInteresCupcake;

                //Se agrega a la tabla
                DgvPan.Rows.Add(TxtCliente.Text, TxtPanFrances.Text, TxtBolillo.Text, TxtCupcake.Text, total.ToString("F2"));

                //Puse el F2 para que solo muestre dos decimales
                if (decimal.TryParse(TxtTotal.Text, out decimal currentTotal))
                {
                    TxtTotal.Text = (currentTotal + total).ToString("F2");
                }
                else
                {
                    TxtTotal.Text = total.ToString("F2");
                }
            }
            //Si no se pone un 0 en el TxtBox se aparecerá ese mensaje
            //MessageBox.Show es para que aparezca el mensaje en pantalla
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
    }
}
