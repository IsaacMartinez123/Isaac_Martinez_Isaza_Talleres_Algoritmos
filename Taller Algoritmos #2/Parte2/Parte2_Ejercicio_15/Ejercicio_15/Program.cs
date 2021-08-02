using System;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Descuento, ValorCompra, TotalPagar;
            Console.WriteLine("Digite el valor de la compra");
            ValorCompra = Convert.ToDouble(Console.ReadLine());

            if (ValorCompra>200000)
            {
                Descuento = ValorCompra * 0.17;
                TotalPagar = ValorCompra - Descuento;
                Console.WriteLine("El total a pagar con el 17% de descuento es: $"+TotalPagar);
            }
            else
                if (ValorCompra<=200000)
            {
                Descuento = ValorCompra * 0.05;
                TotalPagar = ValorCompra - Descuento;
                Console.WriteLine("El total a pagar con el 5% de descuento es: $" + TotalPagar);

            }
        }
    }
}
