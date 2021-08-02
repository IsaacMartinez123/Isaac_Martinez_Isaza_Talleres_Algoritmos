using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double def;

            Console.WriteLine("Digite la primera nota ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite la segunda nota ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite la tercera nota ");
            double n3 = double.Parse(Console.ReadLine());

            n1 = n1 * 0.20;
            n2 = n2 * 0.30;
            n3 = n3 * 0.50;

            Console.WriteLine($"nota 1 igual al 20%: {n1}");
            Console.WriteLine($"nota 2 igual al 30%: {n2}");
            Console.WriteLine($"nota 3 igual al 50%: {n3}");

            def = n1 + n2 + n3;

            Console.WriteLine($"La definitiva del aprendiz es: {def}");

            Console.ReadKey();
        }
    }
}

