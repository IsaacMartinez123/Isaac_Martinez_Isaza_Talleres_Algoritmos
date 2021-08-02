using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double PagoPrincipal, PagoTotal, Descuento, Cantidadkilometros;
            Console.WriteLine("Digite la distancia en kilometros a recorrer, para determinar el precio de su pasaje: ");
            Cantidadkilometros = Convert.ToDouble(Console.ReadLine());

            if (Cantidadkilometros >1000)
            {
                PagoPrincipal = Cantidadkilometros * 150;
                Descuento = PagoPrincipal * 0.30;
                PagoTotal = PagoPrincipal - Descuento;

                System.Console.WriteLine("El valor de su viaje es: " + PagoPrincipal);
                System.Console.WriteLine("El valor de su viaje con el 30% de descuento es: " + PagoTotal);
            }
            else
            {
                PagoPrincipal = Cantidadkilometros * 150;
                Descuento = 0;
                PagoTotal = PagoPrincipal - Descuento;

                System.Console.WriteLine("El valor de su viaje es: $" + PagoPrincipal);
                System.Console.WriteLine("No tienes descueno en tu viaje");
            }
        }
    }
}
