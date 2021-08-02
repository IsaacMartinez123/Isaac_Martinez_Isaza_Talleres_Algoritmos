using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cantidadcuadernos, valorPagar;
            Console.WriteLine("Digite la cantidad de cuadernos comprados");
            Cantidadcuadernos = Convert.ToInt32(Console.ReadLine());

            if (Cantidadcuadernos >=5)
            {
                valorPagar = Cantidadcuadernos * 2000;
                Console.WriteLine("El total a pagar por los cuadernos comprados es: $" + valorPagar);

            }
            else
                if (Cantidadcuadernos<5)
            {
                valorPagar = Cantidadcuadernos * 2500;
                Console.WriteLine("El total a pagar por los cuadernos comprados es: $" + valorPagar);
            }
        }
    }
}
