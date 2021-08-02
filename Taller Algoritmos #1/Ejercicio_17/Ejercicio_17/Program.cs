using System;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps, salarioTotal, fondoPension;

            Console.WriteLine("Ingrese el salario del Empleado");
            int salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el ahorro mensual programado");
            int ahorro = int.Parse(Console.ReadLine());

            eps = salario * 0.125;

            fondoPension = salario * 0.19;

            salarioTotal = salario - ahorro - eps - fondoPension;

            Console.WriteLine($"El salario base es: {salario}");
            Console.WriteLine($"El ahorro mensual programado es:  {ahorro}");
            Console.WriteLine($"La suma a deducir por aporte a la Salud es: {eps}");
            Console.WriteLine($"La suma a deducir por aporte al Fondo de Pensiones es: {fondoPension}");
            Console.WriteLine($"El total a recibir es: {salarioTotal}");

            Console.ReadKey();
        }
    }
}
