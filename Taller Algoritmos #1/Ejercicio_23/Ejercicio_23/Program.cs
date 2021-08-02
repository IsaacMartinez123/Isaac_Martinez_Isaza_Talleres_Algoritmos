using System;

namespace Ejercicio_23
{
    class Program
    {
        static void Main(string[] args)
        {
            double tiempo;

            Console.WriteLine("digite la distancia que va a recorrer");
            double altura = double.Parse(Console.ReadLine());

            tiempo = (altura * 5) / 7;

            Console.WriteLine($"Los metros que va a subir son: {altura}");
            Console.WriteLine($"El tiempo que le tomara suir son: {tiempo}");

            Console.ReadKey();
        }
    }
}
