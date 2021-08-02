using System;

namespace Ejercicio_7
{
    class Program
    {
        public static void EquivalenciaSegundos()
        {
            int H, M, S, SGTOTAL;


            Console.WriteLine("Digite la cantidad de horas");
            H = Convert.ToInt32(Console.ReadLine());
            H = H * 3600;
            Console.WriteLine("Digite la cantidad de minutos");
            M = Convert.ToInt32(Console.ReadLine());
            M = M * 60;
            Console.WriteLine("Digite la cantidad de segundos");
            S = Convert.ToInt32(Console.ReadLine());


            SGTOTAL = H + M + S;

            Console.WriteLine("El tiempo en segundos es: " + SGTOTAL);
        }
        static void Main(string[] args)
        {
            EquivalenciaSegundos();
        }
    }
}
