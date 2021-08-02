using System;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int subtotal;

            double iva, prec_neto;

            Console.WriteLine("Ingrese el valor unitario del producto");
            int prec_uni = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad del producto");
            int cant_prod = int.Parse(Console.ReadLine());

            subtotal = prec_uni * cant_prod;

            iva = subtotal * 0.19;

            prec_neto = subtotal + iva;

            Console.WriteLine($"El valor unitario del producto es: {prec_uni}");
            Console.WriteLine($"La cantidad del producto a llevar es: {cant_prod}");
            Console.WriteLine($"El subtotal es: {subtotal}");
            Console.WriteLine($"El iva es: {iva}");
            Console.WriteLine($"El precio neto es: {prec_neto}");

            Console.ReadKey();
        }
    }
}
