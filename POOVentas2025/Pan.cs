namespace POOVentas2025
{
   public class Pan
    {
        //Propiedades
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
       

        //Se agrega una constante para que después que se ejecute, no se pueda modificar, en este caso los precios
        public const decimal PrecioPanFrances = 4.00m;
        public const decimal PrecioBolillo = 2.80m;
        public const decimal PrecioCupcake = 7.00m;
        public const decimal InteresCupcake = 0.05m;

        //Constructor del Pan
        public Pan(string nombre, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Total = 0;
            Total = Precio * Cantidad;
        }
        //Retorna el total
        public decimal CalcularTotal()
        {
            return Total = Precio * Cantidad;
        }
    }
}
