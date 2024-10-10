using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma1al5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializamos la variable suma en 0 para almacenar la suma de los números.
            int suma = 0;

            // Bucle for que se ejecuta desde 1 hasta 5, inclusive.
            // La variable contador se incrementa en cada iteración.
            for (int contador = 1; contador <= 5; contador++)
            {
                // En cada iteración, sumamos el valor de contador a la variable suma.
                suma += contador;
            }

            // Mostramos el resultado de la suma en la consola.
            Console.WriteLine($"La suma de los números del 1 al 5 es: {suma}");
        }
    }
}

