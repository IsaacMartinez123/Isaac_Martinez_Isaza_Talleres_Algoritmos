using System;

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            double cuota1, cuota2, cuota3, cuota4;

            Console.WriteLine("Ingrese el costo de su matricula");
            int matricula = int.Parse(Console.ReadLine());

            cuota1 = matricula * 0.4;

            cuota2 = matricula * 0.25;

            cuota3 = matricula * 0.2;

            cuota4 = matricula * 0.15;

            Console.WriteLine($"El costo de su primera cuota es: {cuota1}");
            Console.WriteLine($"El costo de su segunda cuota es: {cuota2}");
            Console.WriteLine($"El costo de su tercera cuota es: {cuota3}");
            Console.WriteLine($"El costo de su cuarta cuota es: {cuota4}");

            Console.ReadKey();
        }
    }
}
