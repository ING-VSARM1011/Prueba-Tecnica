using System;

namespace Solucion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa el número entero a convertir: ");
            string numero = Console.ReadLine();

            while (!Program.ValidacionNumero(numero))
            {
                Console.WriteLine("El número ingresado no es entero, por favor ingresar un número entero: ");
                numero = Console.ReadLine();
            }

            Console.WriteLine("Ingresa la base a la cuál se quiere hacer la conversión, debe ser un número entero: ");
            string baseNumero = Console.ReadLine();

            while (!Program.ValidacionNumero(baseNumero))
            {
                Console.WriteLine("El número ingresado no es entero, por favor ingresar un número entero: ");
                baseNumero = Console.ReadLine();
            }

            string resultadoConversion = Program.ConversionBase(numero, baseNumero);

            Console.WriteLine("El resultado conversion es el número " + $"{resultadoConversion}");
        }

        public static string ConversionBase(string numero, string baseNumero)
        {
            int num = int.Parse(numero);
            int baseNum = int.Parse(baseNumero);
            string conversion = Convert.ToString('-');
            while (num / baseNum != 0) {
                conversion = Convert.ToString(num % baseNum) + conversion;
                num = num / baseNum;
            }
            return Convert.ToString(num) + conversion;
        }

        public static bool ValidacionNumero(string numero)
        {
            try
            {
                int num = int.Parse(numero);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}

