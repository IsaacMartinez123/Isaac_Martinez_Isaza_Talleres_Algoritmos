using System;

namespace Ejercicio_3
{
    class Program
    {
        public static void NotasAprendiz() {
            double N1, N2, N3, Definitiva;

            Console.WriteLine("Digite la primer nota del aprendiz");
            N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite la segunda nota del aprendiz");
            N2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite la tercer nota del aprendiz");
            N3 = Convert.ToDouble(Console.ReadLine());

            Definitiva = N1 + N2 + N3;
            Definitiva = Definitiva / 3;
            Console.WriteLine("La nota definitiva de la asignatura del aprendiz es: " + Definitiva);

        }
        static void Main(string[] args)
        {
            NotasAprendiz();
        }
    }
}
