using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 90; i >= 65; i--)
            {
                Console.Write(Convert.ToString((char)i));
            }

            Console.ReadLine();
        }
    }
}