using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Para que se vea el símbolo de moneda en la consola, se debe cambiar la configuración regional de la consola.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double consumo;
            double precio;
            double total;

            Console.Write("Introduce el consumo en kWh: ");
            consumo = Convert.ToDouble(Console.ReadLine());

            if (consumo > 1800)
            {
                precio = 0.8;
            }
            else if (consumo >= 1000)
            {
                precio = 0.12;
            }
            else
            {
                precio = 0.14;
            }

            total = consumo * precio;

            // {0:C2} muestra el importe con formato de moneda y dos decimales.
            Console.WriteLine("El total a pagar es: {0:C2}", total);

            Console.ReadLine();
        }
    }
}