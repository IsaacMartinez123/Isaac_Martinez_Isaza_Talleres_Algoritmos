using System;

namespace Ejercicio_13
{
    class Program
    {
        public static void SueldoHora()
        {
            double HorasT, ValorH, SueldoT;
            Console.WriteLine("Digite la cantidad total de horas trabajadas");
            HorasT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite el valor que se le paga por hora trabajada");
            ValorH = Convert.ToDouble(Console.ReadLine());
            SueldoT = HorasT * ValorH;
            Console.WriteLine("Su sueldo total por el tiempo trabajado es: " + "$" + SueldoT + " pesos");
        }
        static void Main(string[] args)
        {
            SueldoHora();
        }
    }
}
