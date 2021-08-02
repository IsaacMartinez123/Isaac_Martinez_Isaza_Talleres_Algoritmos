using System;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double num_art=4, iva, prec_ven, prec_total;

            Console.WriteLine("Ingrese el presio del articulo");
            int prec_art = int.Parse(Console.ReadLine());

            prec_ven = prec_art * num_art;

            iva = prec_ven * 0.19;

            prec_total = prec_ven + iva;

            Console.WriteLine($"El precio del articulo (1) es: {prec_art}");
            Console.WriteLine($"El precio de los articulos (4) es: {prec_ven}");
            Console.WriteLine($"El iva es; {iva}");
            Console.WriteLine($"El precio total es: {prec_total}");

            Console.ReadKey();

        }
    }
}
