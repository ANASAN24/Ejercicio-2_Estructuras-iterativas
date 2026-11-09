using System;
using System.Collections;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();

            int numero;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Introduce el número " + i + ": ");
                numero = Convert.ToInt32(Console.ReadLine());

                pila.Push(numero);
            }

            Console.WriteLine("Elementos de la pila:");

            foreach (int elemento in pila)
            {
                Console.WriteLine(elemento);
            }

            Console.WriteLine("Extraemos dos elementos:");

            Console.WriteLine("Elemento extraído: " + pila.Pop());
            Console.WriteLine("Elemento extraído: " + pila.Pop());

            Console.WriteLine("Elementos restantes de la pila:");

            foreach (int elemento in pila)
            {
                Console.WriteLine(elemento);
            }

            Console.ReadLine();
        }
    }
}