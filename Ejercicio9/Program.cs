using System;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamaño;

            Console.Write("Introduce el tamaño del array: ");
            tamaño = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("Introduce el número " + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Números pares:");

            for (int i = 0; i < tamaño; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            Console.WriteLine("Números impares:");

            for (int i = 0; i < tamaño; i++)
            {
                if (numeros[i] % 2 != 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
        }
    }
}