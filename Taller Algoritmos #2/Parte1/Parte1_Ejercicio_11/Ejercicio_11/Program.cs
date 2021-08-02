using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, prom;

            Console.WriteLine("Digite la primera nota");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite la segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite la tercera nota");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite la cuarta nota");
            n4 = Convert.ToDouble(Console.ReadLine());
            prom = n1 + n2 + n3 + n4;
            prom = prom / 4;

            if (prom <3.5)
            {
                Console.WriteLine("El resultado es reprobado");
            }
        }
    }
}
