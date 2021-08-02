using System;

namespace Parte2_Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double cal_total;
            int tiempo;

            Console.WriteLine("Si la actividad que va realizar es dormir ingrese el numero 1/ si es estar sentado ingrese 2");
            char respuesta = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los minutos en los que va a realizar esta actividad");
            tiempo = int.Parse(Console.ReadLine());

            if (respuesta == '1')
            {
                cal_total = tiempo * 1.08;
                Console.WriteLine($"La cantidad de calorias consumidas es de: {cal_total}");
            }

            else
            {
                cal_total = tiempo * 1.66;
                Console.WriteLine($"La cantidad de calorias consumidas es de: {cal_total}");
            }
            Console.ReadKey();
        }
    }
}
