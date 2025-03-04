namespace POOVentas2025
{
    public class Venta
    {
        //Propiedades
        public decimal MontoTotal { get; set; }
        public Pago FormaPago { get; set; }
        public decimal TotalConIntereses { get; set; }

        //Lista de los panes
        public List<Pan> productos { get; set; } = new List<Pan>();

        //Constructor
        public Venta(Pago pago)
        {
            MontoTotal = 0;
            FormaPago = pago;
            TotalConIntereses = 0;
        }

        //Método de ClacularTotal que devuelve el total con intereses
        public decimal CalcularTotal()
        {
            decimal total = 0;


            //El foreach ayuda a recorrer la lista de productos
            foreach (Pan producto in productos)
            {
                //Usé el Console.WriteLine para el nombre, cantidad, precio y total del producto
                //Los signos $, se muestra el precio y el total del producto
                //Se puso las unidades x$ para que se muestre el precio por la cantidad del producto
                //Los: se realciona con el nombre del producto y la cantidad
                total += producto.Precio * producto.Cantidad;
                Console.WriteLine($"{producto.Nombre}:{producto.Cantidad}unidades x${producto.Precio}=${producto.Cantidad * producto.Precio}");


            }
            //Esel monto total y el total con intereses
            MontoTotal = total;
            TotalConIntereses = total + (total * FormaPago.Interes);
            return TotalConIntereses;

        }
    }
}
