using System;

namespace Ejercicio_9
{
    class Program
    {
        public static void VentaComision()
        {
            Double Sbase, Cventa1, Cventa2, Cventa3, venta1, venta2, venta3, SueldoyComsion, SumaComisiones;
            Console.WriteLine("Digite el valor de su sueldo base");
            Sbase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite el valor de su primera venta");
            venta1 = Convert.ToDouble(Console.ReadLine());
            Cventa1 = venta1 * 0.1;

            Console.WriteLine("Digite el valor de su segunda venta");
            venta2 = Convert.ToDouble(Console.ReadLine());
            Cventa2 = venta2 * 0.1;

            Console.WriteLine("Digite el valor de su tercera venta venta");
            venta3 = Convert.ToDouble(Console.ReadLine());
            Cventa3 = venta3 * 0.1;


            SueldoyComsion = Sbase + Cventa1 + Cventa2 + Cventa3;
            SumaComisiones = Cventa1 + Cventa2 + Cventa3;



            Console.WriteLine("El valor de su primera comision es: " + Cventa1);
            Console.WriteLine("El valor de su segunda comision es: " + Cventa2);
            Console.WriteLine("El valor de su tercera comision es: " + Cventa3);

            Console.WriteLine("El valor de sus 3 comisiones del mes juntas es : " + SumaComisiones);

            Console.WriteLine("El valor total de su pago con sueldo base y comisiones es : " + SueldoyComsion);
        }
        static void Main(string[] args)
        {
            VentaComision();
        }
    }
}
