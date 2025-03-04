namespace POOVentas2025
{
    //Clase abstracta no se ocupa instanciar
    public abstract class Pago
    {
        public decimal Monto { get; set; }
        public decimal Interes { get; set; }

        public Pago(decimal monto, decimal interes)
        {
            Monto = monto;
            Interes = interes;
        }

        public abstract decimal CalcularTotal();
    }

    //Clase Contado que hereda de Pago
    public class Contado : Pago
    {
        public Contado(decimal monto) : base(monto, 0)
        {

        }

        public override decimal CalcularTotal()
        {
            return Monto;
        }
    }


    //Clase Crédito que hereda de Pago
    public class Credito : Pago
    {
        public Credito(decimal monto) : base(monto, 0.05m)
        {

        }

        public override decimal CalcularTotal()
        {
            return Monto + (Monto * 0.05m);
        }
    }
}
