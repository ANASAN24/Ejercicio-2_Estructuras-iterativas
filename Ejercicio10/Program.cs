using System;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 8, 3, 10, 1, 6, 4, 9, 2, 7, 5 };

            Array.Sort(numeros);

            Console.WriteLine("Números ordenados de menor a mayor:");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.ReadLine();
        }
    }
}