using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;
            string subcadena;
            char letra1;
            char letra2;
            int posicion;
            int inicio;
            int longitud;

            Console.Write("Introduce un texto: ");
            texto = Console.ReadLine();

            Console.WriteLine("La longitud del texto es: " + texto.Length);

            Console.Write("Introduce una palabra para buscar: ");
            subcadena = Console.ReadLine();

            if (texto.Contains(subcadena))
            {
                Console.WriteLine("El texto contiene la subcadena");
            }
            else
            {
                Console.WriteLine("El texto no contiene la subcadena");
            }

            Console.Write("Introduce la letra que quieres reemplazar: ");
            letra1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Introduce la nueva letra: ");
            letra2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Texto reemplazado: " + texto.Replace(letra1, letra2));

            Console.WriteLine("Texto en mayúsculas: " + texto.ToUpper());

            Console.WriteLine("Texto en minúsculas: " + texto.ToLower());

            Console.Write("Introduce la posición del carácter que quieres eliminar: ");
            posicion = Convert.ToInt32(Console.ReadLine());

            if (posicion >= 0 && posicion < texto.Length)
            {
                Console.WriteLine("Texto sin ese carácter: " + texto.Remove(posicion, 1));
            }
            else
            {
                Console.WriteLine("La posición no es válida");
            }

            Console.Write("Introduce la posición inicial de la subcadena: ");
            inicio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce la longitud de la subcadena: ");
            longitud = Convert.ToInt32(Console.ReadLine());

            if (inicio >= 0 && longitud > 0 && inicio + longitud <= texto.Length)
            {
                Console.WriteLine("La subcadena es: " + texto.Substring(inicio, longitud));
            }
            else
            {
                Console.WriteLine("Las posiciones introducidas no son válidas");
            }
        }
    }
}