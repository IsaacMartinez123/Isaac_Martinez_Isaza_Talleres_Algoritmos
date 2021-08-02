using System;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Double CuotaInicial, ValorVivienda, CuotasMensual, IngresosComprador;
            Console.WriteLine("Digite los ingresos mensuales del comprador");
            IngresosComprador = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite el valor de la vivienda");
            ValorVivienda = Convert.ToDouble(Console.ReadLine());

            if (IngresosComprador >=1200000)
            {
                CuotaInicial = (ValorVivienda * 0.15);
                CuotasMensual = (((ValorVivienda * 0.85) / 120) * 1.02);

                Console.WriteLine("La cuota inicial es de: " + CuotaInicial + "\n" +
                "Las cuotas mensuales serán de: " + CuotasMensual);
            }
            else
                if (IngresosComprador<1200000)
            {
                CuotaInicial = (ValorVivienda * 0.30);
                CuotasMensual = (((ValorVivienda * 0.70) / 84) * 1.01);

                Console.WriteLine("La cuota inicial es de: " + CuotaInicial + "\n" +
               "Las cuotas mensuales serán de: " + CuotasMensual);
            }
        }
    }
}
