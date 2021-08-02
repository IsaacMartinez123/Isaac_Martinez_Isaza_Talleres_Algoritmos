using System;

namespace Parte1_Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double interes;

            Console.WriteLine("Ingrese la cantidad de dinero que tiene en el banco");
            double dinero = int.Parse(Console.ReadLine());

            Console.WriteLine("digite la cantidad el porcentaj de intereses que genera en el banco");
            double porcentajeIntereses = double.Parse(Console.ReadLine());

            porcentajeIntereses = porcentajeIntereses / 100;

            interes = dinero * porcentajeIntereses;
            Console.WriteLine($"El interes es: {interes}");

            if (interes < 7000)
            {
                dinero = dinero + interes;
            }
            Console.WriteLine($"El dinero total de su cuenta es: {dinero}");
            Console.ReadKey();
        }
    }
}
