using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Double ValorCompra, RecursosPropios, CreditoBanco,CreditoFabricante, InteresesFabricante;
            Console.WriteLine("Digite el valor de la compra realizada por la empresa");
            ValorCompra = Convert.ToInt32(Console.ReadLine());

            if (ValorCompra >=5000000)
            {
                RecursosPropios = ValorCompra * 0.55;
                CreditoBanco = ValorCompra * 0.3;
                CreditoFabricante = ValorCompra - (RecursosPropios + CreditoBanco);
                InteresesFabricante = CreditoFabricante * 0.15;
                Console.WriteLine("El pago de la piezas se hara de la siguiente manera");
                Console.WriteLine("La empresa pagara con recursos propios: $"+RecursosPropios);
                Console.WriteLine("La empresa solicitara un prestamo al banco de:  $" + CreditoBanco);
                Console.WriteLine("La empresa le pedira al fabricane un credito de: $" + CreditoFabricante);
                Console.WriteLine("El fabricante cobrara de intereses un total de: $" + InteresesFabricante);

            }
            else
                if (ValorCompra<5000000)
            {
                RecursosPropios = ValorCompra * 0.7;
                CreditoFabricante = ValorCompra - RecursosPropios;
                InteresesFabricante = CreditoFabricante * 0.15;
                Console.WriteLine("El pago de la piezas se hara de la siguiente manera");
                Console.WriteLine("La empresa pagara con recursos propios: $" + RecursosPropios);
                Console.WriteLine("La empresa le pedira al fabricane un credito de: $" + CreditoFabricante);
                Console.WriteLine("El fabricante cobrara de intereses un total de: $" + InteresesFabricante);
            }
        }
    }
}
