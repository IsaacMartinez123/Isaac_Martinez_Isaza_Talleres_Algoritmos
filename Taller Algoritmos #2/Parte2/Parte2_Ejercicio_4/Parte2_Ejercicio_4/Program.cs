using System;

namespace Parte2_Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine($"El orden ascendente es: {num1}---{num2}");
            }
            else if (num2 < num1)
            {
                Console.WriteLine($"El orden ascendente es: {num2}---{num1}");
            }
            else
            {
                Console.WriteLine("No puede ingresar 2 numeros iguales");
            }
            Console.ReadKey();
        }
    }
}
