using System;

namespace Solucion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa un número entero: ");
            string primerNumero = Console.ReadLine();

            while (!Program.ValidacionNumero(primerNumero))
            {
                Console.WriteLine("El número ingresado no es entero, por favor ingresar un número entero: ");
                primerNumero = Console.ReadLine();
            }

            Console.WriteLine("Ingresa otro número entero: ");
            string segundoNumero = Console.ReadLine();

            while (!Program.ValidacionNumero(segundoNumero))
            {
                Console.WriteLine("El número ingresado no es entero, por favor ingresar un número entero: ");
                segundoNumero = Console.ReadLine();
            }

            float division = Program.DivisionEnteros(primerNumero, segundoNumero);

            Console.WriteLine("El resultado de la división de los enteros ingresado es " + $"{division}");
        }

        public static float DivisionEnteros(string numero1, string numero2)
        {
            return int.Parse(numero1) / int.Parse(numero2);
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
