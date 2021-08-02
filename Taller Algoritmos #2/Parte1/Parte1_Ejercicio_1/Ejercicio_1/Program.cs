using System;

namespace Ejercicio_1
{
    class Program
    {
        public static void NumeroPar()
        {
            int numero;
            Console.WriteLine("Digite Un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero%2==0)
            {
                Console.WriteLine("¡Digitaste un numero par!  :)");
            }
            else
            {
                Console.WriteLine("¡No digitaste un numero par!  :(");
            }

        }
        static void Main(string[] args)
        {
            NumeroPar();
        }
    }
}
