using System;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numerocubo;
            Console.WriteLine("Digite un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero>=10)
            {
                numerocubo = numero * numero * numero;
                Console.WriteLine("El cubo del numero es : " + numerocubo);
            }
        }
    }
}
