using System;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumaNotas, promedio;

            Console.WriteLine("Ingrese su nombre");
            String nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la primera nota");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera nota");
            double nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cuarta nota");
            double nota4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la quinta nota");
            double nota5 = double.Parse(Console.ReadLine());

            sumaNotas = nota1 + nota2 + nota3 + nota4 + nota5;

            promedio = sumaNotas / 5;

            Console.WriteLine("Ingrese su programa de formación");
            String programa = Console.ReadLine();

            Console.WriteLine("Ingrese su ficha");
            String ficha = Console.ReadLine();

            Console.WriteLine($"Su nombre es: {nombre}");
            Console.WriteLine($"Su programa  es: {programa}");
            Console.WriteLine($"Su ficha es: {ficha}");
            Console.WriteLine($"Su promedio final es: {promedio}");

            Console.ReadKey();
        }
    }
}
