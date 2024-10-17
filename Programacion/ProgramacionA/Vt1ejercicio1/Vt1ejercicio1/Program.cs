namespace Vt1ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escribir un programa donde se muestre por pantalla los números impares desde el 1 al 10.

            // Bucle for que comienza en 1 y termina en 10 (incluido).
            // Se utiliza para recorrer todos los números dentro de este rango.
            for (int i = 1; i <= 10; i++)
            {
                // Condición para verificar si el número es impar.
                // Si el resto de la división de 'i' entre 2 no es 0, entonces es impar.
                if (i % 2 != 0)
                {
                    // Muestra el número impar por pantalla.
                    Console.WriteLine(i);

                    // Este comentario muestra una línea de código que se podría usar para incrementar una variable,
                    // pero no es necesario en este caso, ya que 'i' se incrementa automáticamente en cada iteración del bucle.
                    // numero = numero + 1;
                }
            }

        }
    }
}

