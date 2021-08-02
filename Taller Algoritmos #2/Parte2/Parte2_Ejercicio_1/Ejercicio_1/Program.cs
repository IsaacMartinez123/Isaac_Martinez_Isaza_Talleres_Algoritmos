using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string narticulo;
            int clave;
            double Poriginal, Pdescuento;

            Console.WriteLine("Digite el nombre del ariculo");
            narticulo= Console.ReadLine();
            Console.WriteLine("Digie la clave del articulo");
            clave = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el precio del articulo");
            Poriginal = Convert.ToDouble(Console.ReadLine());

            if (clave ==01)
            {
                Pdescuento = Poriginal * 0.10;
                Pdescuento = Poriginal - Pdescuento;
                Console.WriteLine("La informacion del producto es: " + "nombre=" + narticulo + "," + "Clave= " + clave + "," + "Precio Original= " + Poriginal + ", " + "Precio con descuento=" + Pdescuento);
            }
            else
                if (clave==02)
            {
                Pdescuento = Poriginal * 0.20;
                Pdescuento = Poriginal - Pdescuento;
                Console.WriteLine("La informacion del producto es: " + "nombre=" + narticulo+","+ "Clave= "+ clave+","+"Precio Original= "+Poriginal+", "+"Precio con descuento="+Pdescuento);
                
            }
            else
            {
                Console.WriteLine("Has digitado una clave incorrecta");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
