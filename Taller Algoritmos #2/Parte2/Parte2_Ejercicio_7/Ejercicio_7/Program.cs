using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero%2==0)
            {
                Console.WriteLine("El numero digitado es par");
            }
            else
                if (numero%2==1)
            {
                Console.WriteLine("El numero digitado es impar");
            }

        }
    }
}
