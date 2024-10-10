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
            int suma = 0;


            for (int contador = 1; contador <= 5; contador++)
            {
                suma += contador;
            }
            Console.WriteLine($"la suma de los numeros del 1 al 5 son {suma}");



        }

    }
}
