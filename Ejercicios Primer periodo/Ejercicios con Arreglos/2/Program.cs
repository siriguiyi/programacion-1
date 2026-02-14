using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaramos un arreglo para almacenar 10 números
        int[] numeros = new int[10];

        // Variable para guardar la posición del mayor número par
        int posicionMayorPar = -1;

        // Variable para guardar el mayor número par encontrado
        int mayorPar = int.MinValue;

        // Leemos los 10 números
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Recorremos el arreglo
        for (int i = 0; i < numeros.Length; i++)
        {
            // Verificamos si el número es par
            if (numeros[i] % 2 == 0)
            {
                // Si es el primer par o es mayor que el mayor actual
                if (numeros[i] > mayorPar)
                {
                    mayorPar = numeros[i];
                    posicionMayorPar = i;
                }
            }
        }

        // Mostramos el resultado
        if (posicionMayorPar != -1)
        {
            Console.WriteLine($"El mayor número par es: {mayorPar}");
            Console.WriteLine($"Está en la posición (índice) {posicionMayorPar}");
            Console.WriteLine($"Posición humana: {posicionMayorPar + 1}");
        }
        else
        {
            Console.WriteLine("No se ingresaron números pares.");
        }

        Console.ReadLine(); // Pausa opcional
    }
}
