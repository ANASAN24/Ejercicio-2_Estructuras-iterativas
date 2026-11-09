using System;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int numero;

            numero = aleatorio.Next(10, 31);

            Console.WriteLine("El número aleatorio generado es: " + numero);
        }
    }
}