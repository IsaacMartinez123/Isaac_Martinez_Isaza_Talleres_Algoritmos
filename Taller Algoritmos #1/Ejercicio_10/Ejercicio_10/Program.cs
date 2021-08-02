using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double desc, total;

            Console.WriteLine("Ingrese el valor de su compra");
            double compra = double.Parse(Console.ReadLine());

            desc = compra * 0.15;
            total = compra - desc;

            Console.WriteLine($"El descuento de la compra es: {desc}");
            Console.WriteLine($"El valor total con descuento del 15% es: {total}");

            Console.ReadKey();
        }
    }
}
