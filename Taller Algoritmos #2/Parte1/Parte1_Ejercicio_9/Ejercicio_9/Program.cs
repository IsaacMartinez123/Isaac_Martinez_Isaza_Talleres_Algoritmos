using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite un numero");
            num = Convert.ToInt32(Console.ReadLine());

            if (num%5==0)
            {
                Console.WriteLine("El numero digitado es un multiplo de 5");
            }
        }
    }
}
