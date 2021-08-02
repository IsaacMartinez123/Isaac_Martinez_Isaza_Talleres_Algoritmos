using System;

namespace Ejercicio_5
{
    class Program
    {

        public static void DescuentoAlmacen()
        {
            double valor_venta, descuento;
            Console.WriteLine("Digite el valor de la venta");
            valor_venta = Convert.ToInt32(Console.ReadLine());

            if (valor_venta>100000)
            {
                descuento = valor_venta * 0.20;

                descuento= valor_venta - descuento;

                Console.WriteLine("Su compra tiene un 20% de descuento y el total a pagar es: " + "$"+descuento);


            }
            else
            {
                Console.WriteLine("Su compra no tiene descuento y el total a pagar es: " + "$"+valor_venta);
            }
        }
        static void Main(string[] args)
        {
            DescuentoAlmacen();
        }
    }
}
