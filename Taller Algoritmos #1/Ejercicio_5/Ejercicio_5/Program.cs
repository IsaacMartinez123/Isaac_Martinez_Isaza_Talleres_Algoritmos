using System;

namespace Ejercicio_5
{
    class Program
    {
        public static void VelocidadDesplazamiento()
        {
            Decimal V, D, T, M, K;


            Console.WriteLine("Digite la distancia en kilometros del auto");
            K = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite el tiempo del recorrido en horas");
            T = Convert.ToDecimal(Console.ReadLine());

            M = T * 60;
            D = K * 1000;
            Console.WriteLine("Esta es la distancia recorrida en metros: " + D);
            Console.WriteLine("Este es el tiempo tardado en minuos: " + M);

            V = K / T;


            Console.WriteLine("La velocidad a la cual se desplazaba el auto es: " + V + " kilometros por hora");
        }
        static void Main(string[] args)
        {
            VelocidadDesplazamiento();
        }
    }
}
