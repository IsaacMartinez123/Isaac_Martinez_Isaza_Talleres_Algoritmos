using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite un numero ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Digitaste un numero negativo");
            }


        }
    }
}
