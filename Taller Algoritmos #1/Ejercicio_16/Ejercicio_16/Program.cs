using System;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double din_condu;

            Console.WriteLine("Ingrese el dinero total recaudado en el dia");
            double din_recau = double.Parse(Console.ReadLine());

            din_condu = din_recau * 0.19;

            Console.WriteLine($"El dinero que le corresponde al conductor es: {din_condu}");

            Console.ReadKey();
        }
    }
}
