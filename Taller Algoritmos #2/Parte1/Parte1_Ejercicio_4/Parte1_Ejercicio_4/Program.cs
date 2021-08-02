using System;

namespace Parte1_Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma;

            Console.WriteLine("Ingrese el primer numero");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            double num2 = double.Parse(Console.ReadLine());

            if (num1>num2) 
            {
                suma = num1 + num2;
                Console.WriteLine($"La suma es: {suma}");
            }

            else 
            {
                Console.WriteLine("No se realizo la suma por que el primer numero es menor  o igual que el segundo ");
            }

            Console.ReadKey();
        }
    }
}
