using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = new Random().Next(0, 100);
            var num2 = new Random().Next(0, 100);

            int suma, resta, multi;

            float div;

            Console.WriteLine($"El numero 1 es: {num1}");
            Console.WriteLine($"El numero 2 es: {num2}");

            suma = num1 + num2;
            resta = num1 - num2;
            multi = num1 * num2;
            div = (float)num1 / num2;

            Console.WriteLine($"El resultado de la suma es: {suma}");
            Console.WriteLine($"El resultado de la resta es: {resta}");
            Console.WriteLine($"El resultado de la multiplicacion es: {multi}");
            Console.WriteLine($"El resultado de la division es: {div}");

            Console.ReadKey();
        }
    }
}
