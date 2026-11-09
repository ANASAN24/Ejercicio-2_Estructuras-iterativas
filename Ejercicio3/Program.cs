using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char estadoCivil;

            Console.Write("Introduce tu estado civil (C, S, V o D): ");
            estadoCivil = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (estadoCivil)
            {
                case 'C':
                    Console.WriteLine("Tu estado civil es Casad@");
                    break;

                case 'S':
                    Console.WriteLine("Tu estado civil es Solter@");
                    break;

                case 'V':
                    Console.WriteLine("Tu estado civil es Viud@");
                    break;

                case 'D':
                    Console.WriteLine("Tu estado civil es Divorciad@");
                    break;

                default:
                    Console.WriteLine("La opción introducida no es correcta");
                    break;
            }

            Console.ReadLine();
        }
    }
}