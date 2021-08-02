using System;

namespace Parte_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int Respu = 0;

            System.Console.Write("1. Ejercicio 1\n2. Ejercicio 2\n3. Ejercicio 3\n4. Ejercicio 4\n5. Salir del programa\nElija una opción para ejecutar: ");
            Respu = Convert.ToInt32(Console.ReadLine());

            Boolean inicio = true;

            while (inicio)
            {

                switch (Respu)
                {
                    case 1:
                        Ejercicio_1();
                        break;
                    case 2:
                        Ejercicio_2();
                        break;
                    case 3:
                        Ejercicio_3();
                        break;
                    case 4:
                        Ejercicio_4();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa");
                        inicio = false;
                        break;

                    default:
                        Console.WriteLine("\n.........Introduce una opción correcta...........\n");
                        break;
                }

                if (inicio)
                {
                    Console.Write("\n\n1. Ejercicio 1\n2. Ejercicio 2\n3. Ejercicio 3\n4. Ejercicio 4\n5. Salir del programa\nElija un ejercicio para ejecutar: ");
                    Respu = int.Parse(Console.ReadLine());
                }

            }
        }



        
        public static void Ejercicio_1()
        {
            int cont = 0;

            System.Console.Write("\n-----------Números primos-----------\nDigite un número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j <= num; j++)
            {
                if (!((j % 2) == 0))
                {
                    cont++;
                }

            }
            Console.WriteLine("\nHay " + cont + " números impares entre el 1 y el " + num);
        }


       
        public static void Ejercicio_2()
        {

            Console.Write("\n-----------Sueldo mayor-----------\nIngrese el número de suledos que desea introducir: ");
            int NumSueldo = Convert.ToInt32(Console.ReadLine());

            int[] Sueldo;
                Sueldo = new int[NumSueldo];

            for (int j = 0; j < NumSueldo; j++)
            {
                Console.Write("\nIngrese el sueldo " + (j + 1) + ": ");
                Sueldo[j] = Convert.ToInt32(Console.ReadLine());
            }

            int mayor = 0, menor = 0;
            mayor = menor = Sueldo[0];

            for (int i = 0; i < Sueldo.Length; i++)
            {
                if (Sueldo[i] > mayor)
                {
                    mayor = Sueldo[i];
                }
            }

            Console.WriteLine("\n----El sueldo mayor es: " + mayor);
        }



        public static void Ejercicio_3()
        {

            int num = 0, unidad = 0, decena = 0;
            String uni = "", sobreD = "", dec = "";

            Console.Write("\n--------De número a texto-------\nIngresa un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            decena = num / 10;
            unidad = (num % 10) / 1;

            if (unidad == 1)
                uni = "uno";
            else if (unidad == 2)
                uni = "dos";
            else if (unidad == 3)
                uni = "tres";
            else if (unidad == 4)
                uni = "cuatro";
            else if (unidad == 5)
                uni = "cinco";
            else if (unidad == 6)
                uni = "seis";
            else if (unidad == 7)
                uni = "siete";
            else if (unidad == 8)
                uni = "ocho";
            else if (unidad == 9)
                uni = "nueve";

            if (decena == 1 && unidad == 0)
                sobreD = "diez";
            else if (decena == 1 && unidad == 1)
                sobreD = "once";
            else if (decena == 1 && unidad == 2)
                sobreD = "doce";
            else if (decena == 1 && unidad == 3)
                sobreD = "trece";
            else if (decena == 1 && unidad == 4)
                sobreD = "catorce";
            else if (decena == 1 && unidad == 5)
                sobreD = "quince";
            else if (decena == 1 && unidad == 6)
                sobreD = "dieciseis";
            else if (decena == 1 && unidad == 7)
                sobreD = "diecisiete";
            else if (decena == 1 && unidad == 8)
                sobreD = "dieciocho";
            else if (decena == 1 && unidad == 9)
                sobreD = "diecinueve";

            if (decena == 2)
                dec = "veinte";
            else if (decena == 3)
                dec = "treinta";
            else if (decena == 4)
                dec = "cuarenta";
            else if (decena == 5)
                dec = "cincuenta";
            else if (decena == 6)
                dec = "sesenta";
            else if (decena == 7)
                dec = "setenta";
            else if (decena == 8)
                dec = "ochenta";
            else if (decena == 9)
                dec = "noventa";

            if (num < 10)
                Console.WriteLine("\nEl numero es: " + uni);
            else if (num < 20)
                Console.WriteLine("\nEl numero es: " + sobreD);
            else if (num < 100)
            {
                if (num % 10 == 0)
                {
                    Console.WriteLine("\nEl numero es: " + dec);
                }
                else
                {
                    Console.WriteLine("\nEl numero es: " + dec + " y " + uni + "\n");
                }
            }
        }



       
        public static void Ejercicio_4()
        {
            string letra = "";

            Console.Write("\n----------Identificador de letra----------\nDijite una letra del abecedario: ");
            letra = Console.ReadLine();

            if (letra.Equals("a", StringComparison.InvariantCultureIgnoreCase) || letra.Equals("e", StringComparison.InvariantCultureIgnoreCase) || letra.Equals("i", StringComparison.InvariantCultureIgnoreCase) || letra.Equals("o", StringComparison.InvariantCultureIgnoreCase) || letra.Equals("u", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("La letra es una vocal");
            }
            else
            {
                Console.WriteLine("La letra es una consonante");
            }

        }
    }
}
