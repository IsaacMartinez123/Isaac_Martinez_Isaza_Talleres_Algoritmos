using System;

namespace Ejercicio_24
{
    class Program
    {
        static void Main(string[] args)
        {
            double interes_anu, interes_mens, primer_mes, primer_año, trimestre, total;

            Console.WriteLine("Ingrese el monto del prestamo");
            int mont_prest = int.Parse(Console.ReadLine());// 500.000

            interes_anu = mont_prest * 0.05; //25.000

            interes_mens = interes_anu * 0.12;//3.000

            primer_mes = interes_anu * 0.12;//3.000

            primer_año = interes_mens * 12;//36.000

            trimestre = interes_mens * 9;//27.000

            total = mont_prest + interes_anu * 5;//2.625.000

            Console.WriteLine($"El monto del prestamo es: {mont_prest}");
            Console.WriteLine($"el primer año se pagaron: {primer_año}");
            Console.WriteLine($"en el tercer trimestre del año se pagaron: {trimestre}");
            Console.WriteLine($"el primer mes se pagaron: {primer_mes}");
            Console.WriteLine($"el valor a pagar del prestamo incluyendo los interes es: {total}");

            Console.ReadKey();
        }
    }
}
