using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_pers;

            double porc_hom, porc_muj;

            Console.WriteLine("Ingrese el numero de hombres que hay en el grupo");
            int num_hom = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de mujeres que hay en el grupo");
            int num_muj = int.Parse(Console.ReadLine());

            total_pers = num_hom + num_muj;

            porc_hom = (num_hom * 100) / total_pers;

            porc_muj = (num_muj * 100) / total_pers;
            
            Console.WriteLine($"El numero de alumnos que hay en el grupo es: {total_pers}");
            
            Console.WriteLine($"El porcentaje de hombres en el grupo es: {porc_hom}%");

            Console.WriteLine($"El porcentaje de mujeres en el grupo es: {porc_muj}%");

            Console.ReadKey();

        }
    }
}
