using System;

namespace Ejercicio_3
{
    class Program
    {
        public static void ComputadorDescuento()
        {
            Double Descuento, Iva, ValorVenta, ValorTotal,b;
            Console.WriteLine("Digite el valor del computador");
            ValorVenta = Convert.ToDouble(Console.ReadLine());
            Iva = ValorVenta * 0.19;
            ValorTotal = ValorVenta + Iva;
            if (ValorVenta>=1000000)
            {
                Iva = ValorVenta * 0.19;
                ValorTotal = ValorVenta + Iva;
                Descuento = ValorTotal * 0.10;
                ValorTotal = ValorTotal - Descuento;
                Console.WriteLine("El valor total a pagar por el computador con IVA incluido y descuento es: " + "$" + ValorTotal);
            }
            else
            {
                Console.WriteLine("El valor total a pagar por el computador con IVA incluido sin descuento es: " + "$" + ValorTotal);
            }

            
            



        }
        static void Main(string[] args)
        {
            ComputadorDescuento();

        }
    }
}
