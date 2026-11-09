using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado;

            Console.Write("Introduce un número del 1 al 9: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 1 && numero <= 9)
            {
                for (int i = 1; i <= 10; i++)
                {
                    resultado = numero * i;

                    Console.WriteLine(numero + " x " + i + " = " + resultado);
                }
            }
            else
            {
                Console.WriteLine("El número introducido no está entre 1 y 9");
            }

            Console.ReadLine();
        }
    }
}