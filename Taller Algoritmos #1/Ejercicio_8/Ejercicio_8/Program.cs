using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double pago_banco_mens, din_total;

            Console.WriteLine("Ingrese la capital que desea invertir");
            int cap = int.Parse(Console.ReadLine());

            pago_banco_mens = cap * 0.2;

            din_total = cap + pago_banco_mens;

            Console.WriteLine($"El dinero obtenido a razon del 2% mensual es: {pago_banco_mens}");

            Console.WriteLine($"El dinero total es: {din_total}");

            Console.ReadKey();
        }
    }
}
