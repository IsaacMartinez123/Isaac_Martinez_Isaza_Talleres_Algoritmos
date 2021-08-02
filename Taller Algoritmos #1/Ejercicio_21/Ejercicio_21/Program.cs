using System;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("Ingrese el nombre del aprendiz");
            String nom = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento del aprendiz (año/mes/dia)");
            DateTime fecha_naci = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la dirección del aprendiz");
            String direccion = Console.ReadLine();

            edad = DateTime.Today.Year - fecha_naci.Year;

            Console.WriteLine($"El nombre del aprendiz es: {nom}");
            Console.WriteLine($"La fecha de nacimiento es: {fecha_naci}");
            Console.WriteLine($"La edad del aprendiz es: {edad}");
            Console.WriteLine($"La direccion del aprendiz es: {direccion}");

            Console.ReadKey();
        }
    }
}
