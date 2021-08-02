using System;

namespace Ejercicio_14
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
                numero = numero * numero * numero;
                Console.WriteLine("El numero digitado es par y su cubo es: " + numero);
            }
            else
                if (numero%2==1)
            {
                numero = numero * 3;
                Console.WriteLine("El numero digitado es impar y su triple es: " + numero);
            }
        }
    }
}
