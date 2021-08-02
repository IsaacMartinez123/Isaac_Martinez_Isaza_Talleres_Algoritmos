using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Double CantidadHoras, SalarioSemanal, HorasExtras, ValorExtra, HoraNormal=40;
            Double ValorHora = 10000;
            Double ValorHoraExtra=15000;
            Console.WriteLine("Digite las horas trabajadas por el obrero en la semana");
            CantidadHoras = Convert.ToDouble(Console.ReadLine());

            if (CantidadHoras<=40)
            {
                SalarioSemanal = CantidadHoras * ValorHora;
                Console.WriteLine("El sueldo del obrero por las horas laboradas en la semana es: " +"$"+ SalarioSemanal);
            }
            else
                if (CantidadHoras>40)
            {
                HorasExtras = CantidadHoras - 40;
                ValorExtra = HorasExtras * ValorHoraExtra;
                SalarioSemanal = (HoraNormal * ValorHora) + ValorExtra;
                Console.WriteLine("El sueldo del obrero por las horas extras es: " +"$"+ ValorExtra);
                Console.WriteLine("El sueldo del obrero por las horas laboradas en la semana es: " +"$"+ SalarioSemanal);

            }


        }
    }
}
