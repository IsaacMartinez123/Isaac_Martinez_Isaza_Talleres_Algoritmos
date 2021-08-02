using System;

namespace Parte2_Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_camis;
            double desc, total_con_desc;

            Console.WriteLine("Ingrese el precio de las camisas");
            int camisa = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de camisas que va a comprar");
            int cant = int.Parse(Console.ReadLine());

            total_camis = camisa * cant;
            Console.WriteLine($"El precio total de ls camisas es: {total_camis}");

            if (cant >= 3)
            {
                desc = total_camis * 0.20;
                Console.WriteLine($"el descuento es: {desc}");
                total_con_desc = total_camis - desc;
                Console.WriteLine($"El total de la compra con 20% de descuento es: {total_con_desc}");
            }
            else
            {
                desc = total_camis * 0.10;
                Console.WriteLine($"el descuento es: {desc}");
                total_con_desc = total_camis - desc;
                Console.WriteLine($"El total de la compra con 10% de descuento es: {total_con_desc}");
            }

            Console.ReadKey();
        }
    }
}
