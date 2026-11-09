using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            string resultado;

            Console.Write("Introduce el primer número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("El primer número es mayor");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("El segundo número es mayor");
            }
            else
            {
                Console.WriteLine("Los dos números son iguales");
            }
        }
    }
}