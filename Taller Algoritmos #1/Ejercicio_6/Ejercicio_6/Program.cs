using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double iva, desc = 0.10, total_desc, iva_con_desc, val_total;


            Console.WriteLine("Ingrese el valor de la compra");
            double valor_compra = double.Parse(Console.ReadLine());

            Console.WriteLine("Se le autorizo descuento?.. Escriba s si es SI/n si es NO");
            char respuesta = char.Parse(Console.ReadLine());

            if (respuesta == 's')
            {

                Console.WriteLine($"El valor total de la compra es: {valor_compra}");

                desc = desc * valor_compra;
                Console.WriteLine($"El descuento es: {desc}");

                total_desc = valor_compra - desc;
                Console.WriteLine($"El valor de la compra con descuento es: {total_desc}");

                iva_con_desc = total_desc * 0.19;
                Console.WriteLine($"El valor del iva despues del descuento es: {iva_con_desc}");

                val_total = total_desc + iva_con_desc;
                Console.WriteLine($"El valor total de la compra es: {val_total}");
            }

            else
            {
                Console.WriteLine($"El valor de la compra es: {valor_compra}");

                iva = valor_compra * 0.19;
                Console.WriteLine($"El iva de la compra es: {iva}");

                val_total = valor_compra + iva;
                Console.WriteLine($"El valor total de la compra es: {val_total}");
            }
            Console.ReadKey();
        }
    }
}
