namespace Vt1ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa donde se muestre por pantalla los números impares desde el 1 al 10.

            int numero = 1;

            while (numero <= 10)
            {

                Console.WriteLine(numero);
                numero = numero + 2;

            }

            Console.WriteLine("El programa ha terminado.");

        }
    }
}
