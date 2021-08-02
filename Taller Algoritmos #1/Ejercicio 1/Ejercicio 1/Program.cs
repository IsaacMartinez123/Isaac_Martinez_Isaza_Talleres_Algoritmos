using System;

namespace Ejercicio_1
{
    class Program
    {

        public static void SumarNumeros()
        {
            int num1;
            int num2;
            int num3;
            int suma;




            Console.WriteLine("Digite el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el tercer  numero");
            num3 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2 + num3;

            Console.WriteLine("El resultado de la suma es: " + suma);

        }
        static void Main(string[] args)
        {

            SumarNumeros();
        }
    }
}
