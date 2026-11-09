using System;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int factorial;

            factorial = 1;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("El factorial de " + numero + " es: " + factorial);

            Console.ReadLine();
        }
    }
}