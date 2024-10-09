namespace Vt1ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializa la variable n a -1 para asegurar que el programa ingrese al bucle while.
            int n = -1;
            int contador; // Declaración de la variable contador que se usará más adelante.
            int factorial = 1; // Inicializa factorial a 1, ya que es el valor multiplicador inicial.

            // Bucle while que se ejecuta mientras n sea negativo.
            while (n < 0)
            {
                // Solicita al usuario que introduzca un número para calcular su factorial.
                Console.WriteLine("Introduce el numero para calcular su Factorial:");

                // Manejo de excepciones para la entrada del usuario.
                try
                {
                    // Intenta leer la entrada del usuario y convertirla a un entero.
                    n = int.Parse(Console.ReadLine());

                    // Verifica si el número ingresado es negativo.
                    if (n < 0)
                    {
                        // Si n es negativo, muestra un mensaje de error.
                        Console.WriteLine("El numero introducido no puede ser negativo, vuelva a intentarlo");
                    }
                }
                /* Captura una excepción si la entrada no es un número entero válido.(Por ejemplo, si el usuario ingresa una cadena de texto que no
                   se puede convertir a un número entero, como "abc" o "12.34", entonces se lanzaría esta excepción.)*/
                catch (FormatException)
                {
                    // Muestra un mensaje de error si la entrada no es válida.
                    Console.WriteLine("Entrada no válida. Por favor, introduce un número entero.");
                }
            }

            // Bucle for que calcula el factorial de n.
            for (contador = 1; contador <= n; contador++)
            {
                // Multiplica el valor actual de factorial por el contador.
                factorial = factorial * contador;
            }

            // Muestra el resultado del cálculo del factorial al usuario.
            Console.WriteLine($"El resultado factorial de  {n}  es  {factorial}");
        }
    }
}