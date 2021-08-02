using System;

namespace Parte1_Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            double num = double.Parse(Console.ReadLine());

            if (num >= 10)
            {
                num = num * 3;
                Console.WriteLine($"El numero triplificado es:  {num}");
            }
            else 
            {
                Console.WriteLine($"El numero es:  {num}");
            }
            Console.ReadKey();
        }
    }
}
