namespace Vt1ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer el diagrama de flujo de un programa que calcule el Factorial de un número N obtenido por consola (N! = 1*2*3....*N)
            int n;
            int contador;
            int factorial = 1;

            Console.WriteLine("Introduce el numero para calcular su Factorial:");
            n= int.Parse(Console.ReadLine());

            for(contador = 1; contador <= n; contador++)
                factorial=factorial*contador;
                
                Console.WriteLine($"El resultado factorial de  {n}  es  {factorial}");

        }
    }
}
