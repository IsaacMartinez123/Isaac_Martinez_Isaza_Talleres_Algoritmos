using System;

namespace Parte2_Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double numpulsaciones;

            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su sexo... M si es masculino/F si es femenino");
            char sexo = char.Parse(Console.ReadLine());

            if (sexo=='M')
            {
                numpulsaciones = (210 - edad) / 10;
                Console.WriteLine($"El numero de pulsaciones que deberia de tener por cada 10 segundos es: {numpulsaciones}");
            }

            else
            {
                numpulsaciones = (220 - edad) / 10;
                Console.WriteLine($"El numero de pulsaciones que deberia de tener por cada 10 segundos es: {numpulsaciones}");
            }
            Console.ReadKey();
        }
    }
}

