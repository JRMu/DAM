using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT03__maximoN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroAlto = -1;  // Valor inicial para detectar si no se ingresaron números positivos

            Console.WriteLine("Introduce un número entero:");
            int n = Int32.Parse(Console.ReadLine());

            // Verificar si el primer número es negativo antes de actualizar numeroAlto
            if (n < 0)
            {
                Console.WriteLine("No se ingresó ningún número positivo.");
                return;
            }

            // Si el primer número es positivo, inicializamos numeroAlto con ese valor
            numeroAlto = n;

            while (true)
            {
                Console.WriteLine("Introduce un número entero:");
                n = Int32.Parse(Console.ReadLine());

                // Salimos del bucle si se ingresa un número negativo
                if (n < 0)
                {
                    break;
                }

                // Actualizamos numeroAlto solo si el número es mayor que el actual
                if (n > numeroAlto)
                {
                    numeroAlto = n;
                }
            }

            Console.WriteLine($"El número más alto ingresado es: {numeroAlto}");
        }
    }
}
