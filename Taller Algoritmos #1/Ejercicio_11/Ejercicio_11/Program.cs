using System;

namespace Ejercicio_11
{
    class Program
    {
        public static void CalificacionFinal()
        {
            Double CF, P1, P2, P3, PP, TF, EF, SP, NP;
            Console.WriteLine("Digite su Calificacion parcial #1");
            P1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite su Calificacion parcial #2");
            P2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite su Calificacion parcial #3");
            P3 = Convert.ToDouble(Console.ReadLine());

            SP = P1 + P2 + P3;
            PP = SP / 3;

            NP = PP * 0.55;

            Console.WriteLine("Digite la calificacion de su examen final");
            EF = Convert.ToDouble(Console.ReadLine());
            EF = EF * 0.3;

            Console.WriteLine("Digite la calificacion de su trabajo final");
            TF = Convert.ToDouble(Console.ReadLine());
            TF = TF * 0.15;


            CF = NP + EF + TF;

            Console.WriteLine("Su calificacion final es: " + CF);
        }
        static void Main(string[] args)
        {
            CalificacionFinal();
        }
    }
}
