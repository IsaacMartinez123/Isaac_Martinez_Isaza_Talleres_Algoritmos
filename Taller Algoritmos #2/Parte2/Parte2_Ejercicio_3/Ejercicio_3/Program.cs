using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double numero;
            Console.WriteLine("Digite un numero");
            numero = Convert.ToDouble(Console.ReadLine());
            if (numero >= 10)
            {
                numero = numero * 3;
                Console.WriteLine("El numero es: " + numero);

            }
            else
            
            if (numero < 10)
            {
                numero = numero / 4;
                Console.WriteLine("El numero es: " + numero);

            }
        }
    }
}
