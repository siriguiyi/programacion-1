using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedimos el primer número
        Console.Write("Ingrese el primer número entero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        // Pedimos el segundo número
        Console.Write("Ingrese el segundo número entero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        // Calculamos la diferencia absoluta entre ambos
        int diferencia = Math.Abs(numero1 - numero2);

        // Verificamos si la diferencia es menor o igual a 10
        if (diferencia <= 10)
        {
            // Determinamos cuál es el menor y cuál es el mayor
            int menor = Math.Min(numero1, numero2);
            int mayor = Math.Max(numero1, numero2);

            Console.WriteLine("Números comprendidos entre el menor y el mayor:");

            // Mostramos todos los números desde el menor hasta el mayor
            for (int i = menor; i <= mayor; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("La diferencia es mayor que 10. No se muestran números.");
        }

      
    }
}
