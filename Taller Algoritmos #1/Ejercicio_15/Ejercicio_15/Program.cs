using System;

namespace Ejercicio_15
{
    class Program
    {
        public static void RegistrarVenta()
        {
            Double IVA, VALOR_VENTA, CAMBIO, DINERO_DEL_CLIENTE;
            Console.WriteLine("Digite el valor de la venta");
            VALOR_VENTA = Convert.ToDouble(Console.ReadLine());
            IVA = VALOR_VENTA * 0.19;
            VALOR_VENTA = VALOR_VENTA + IVA;

            Console.WriteLine("El valor del IVA de la venta es: " + "$" + IVA);
            Console.WriteLine("El valor total de la venta con IVA incluido es: " + "$" + VALOR_VENTA);


            Console.WriteLine("Digite la cantidad de dinero entregada por el cliente");
            DINERO_DEL_CLIENTE = Convert.ToDouble(Console.ReadLine());

            CAMBIO = DINERO_DEL_CLIENTE - VALOR_VENTA;

            Console.WriteLine("El cambio del cliente es: " + "$" + CAMBIO);
        }
        static void Main(string[] args)
        {
            RegistrarVenta();
        }
    }
}
