using System;

namespace Parte1_Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su estatura");
            double estatura = double.Parse(Console.ReadLine());

            if (estatura > 1.70)
            {
                Console.WriteLine("Usted es alto");
            }
            else
            {
                Console.WriteLine("Usted es bajo");
            }
            Console.ReadKey();
        }
    }
}
