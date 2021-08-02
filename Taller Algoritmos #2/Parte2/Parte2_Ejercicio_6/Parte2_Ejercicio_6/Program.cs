using System;

namespace Parte2_Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double retenc, salario_total;

            Console.WriteLine("Ingrese salario del empleado");
            double salario = double.Parse(Console.ReadLine());

            if (salario >= 2000000)
            {
                retenc = salario * 0.10;
                Console.WriteLine($"La retencion del 10% es: {retenc}");
                salario_total = salario - retenc;
                Console.WriteLine($"El salario del empleado con retencion del 10% es: {salario_total}");
            }

            else
            {
                retenc = salario * 0.3;
                Console.WriteLine($"La retencion del 3% es: {retenc}");
                salario_total = salario - retenc;
                Console.WriteLine($"El salario del empleado con retencion del 3% es: {salario_total}");
            }
            Console.ReadKey();
        }
    }
}
