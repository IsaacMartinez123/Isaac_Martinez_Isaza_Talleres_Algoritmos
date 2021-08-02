using System;

namespace Parte_3
{
    class Program
    {
        static int EjercicioUno(int n)
        {
            int contadorPrimos = 0, j;
            bool primo;

            for (int i = 1; i <= n; i++)
            {
                primo = true;
                j = 2;

                while (j <= i - 1 && primo == true)
                {
                    if (i % j == 0) primo = false;

                    j++;
                }
                if (primo) contadorPrimos++;
            }

            return contadorPrimos;
        }
        public static void EjercicioDos(int n)
        {
            int sueldoMayor = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Ingrese el salario #" + i + ": ");
                int sueldo = int.Parse(Console.ReadLine());

                if (sueldo > sueldoMayor) sueldoMayor = sueldo;


            }
            Console.WriteLine("el sueldo mayor es: " + sueldoMayor);

        }
        static string EjercicioTres(int num)
        {
            int unidad, decena;
            String unidadEscrito = "", sobreDiez = "", decenaEscrito = "", resultado = "";

            decena = num / 10;
            unidad = (num % 10) / 1;

            if (unidad == 1)
                unidadEscrito = "uno";
            else if (unidad == 2)
                unidadEscrito = "dos";
            else if (unidad == 3)
                unidadEscrito = "tres";
            else if (unidad == 4)
                unidadEscrito = "cuatro";
            else if (unidad == 5)
                unidadEscrito = "cinco";
            else if (unidad == 6)
                unidadEscrito = "seis";
            else if (unidad == 7)
                unidadEscrito = "siete";
            else if (unidad == 8)
                unidadEscrito = "ocho";
            else if (unidad == 9)
                unidadEscrito = "nueve";

            if (decena == 1 && unidad == 0)
                sobreDiez = "diez";
            else if (decena == 1 && unidad == 1)
                sobreDiez = "once";
            else if (decena == 1 && unidad == 2)
                sobreDiez = "doce";
            else if (decena == 1 && unidad == 3)
                sobreDiez = "trece";
            else if (decena == 1 && unidad == 4)
                sobreDiez = "catorce";
            else if (decena == 1 && unidad == 5)
                sobreDiez = "quince";
            else if (decena == 1 && unidad == 6)
                sobreDiez = "dieciseis";
            else if (decena == 1 && unidad == 7)
                sobreDiez = "diecisiete";
            else if (decena == 1 && unidad == 8)
                sobreDiez = "dieciocho";
            else if (decena == 1 && unidad == 9)
                sobreDiez = "diecinueve";

            if (decena == 2)
                decenaEscrito = "veinte";
            else if (decena == 3)
                decenaEscrito = "treinta";
            else if (decena == 4)
                decenaEscrito = "cuarenta";
            else if (decena == 5)
                decenaEscrito = "cincuenta";
            else if (decena == 6)
                decenaEscrito = "sesenta";
            else if (decena == 7)
                decenaEscrito = "setenta";
            else if (decena == 8)
                decenaEscrito = "ochenta";
            else if (decena == 9)
                decenaEscrito = "noventa";

            if (num < 10)
                resultado = "El numero es: " + unidad;
            else if (num < 20)
                resultado = "El numero es: " + sobreDiez;
            else if (num < 100)
            {
                if (num % 10 == 0)
                {
                    resultado = "El numero es: " + decenaEscrito;
                }
                else
                {
                    resultado = ("El numero es: " + decenaEscrito + " y " + unidadEscrito);
                }
            }
            return resultado;
        }
        static void EjercicioCuatro(string consonante)
        {
            string clasificacion = "";
            if (consonante == "a") clasificacion = "vocal";
            else if (consonante == "e") clasificacion = "vocal";
            else if (consonante == "i") clasificacion = "vocal";
            else if (consonante == "o") clasificacion = "vocal";
            else if (consonante == "u") clasificacion = "vocal";
            else clasificacion = "consonante";

            Console.WriteLine("La Letra es: " + clasificacion);
        }

        static void Main(string[] args)
        {


            Console.WriteLine("Ingrese una opcion: \n" +
                "1. Numeros primos entre el 1 al n \n" +
                "2. Encontrar sueldo maximo \n" +
                "3. Numero escrito \n" +
                "4. Vocal o consonante");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ingrese un numero limite para hallar numeros primos");
                    int cantidadPrimos = EjercicioUno(int.Parse(Console.ReadLine()));
                    Console.WriteLine("La cantidad de numeros primos es: " + cantidadPrimos);
                    break;
                case "2":
                    Console.WriteLine("Ingrese numero de sueldos a ingresar");
                    EjercicioDos(int.Parse(Console.ReadLine()));

                    break;
                case "3":
                    Console.WriteLine("Ingrese un numero del 1-99 a escibir");
                    string numeroEscrito = EjercicioTres(int.Parse(Console.ReadLine()));
                    Console.WriteLine(numeroEscrito);
                    break;
                case "4":
                    Console.WriteLine("Ingrese una letra para verificar");
                    EjercicioCuatro(Console.ReadLine());
                    break;
            }
        }
    }
}
