using System;

class Program
{
    // Función para determinar si un número es primo
    static bool EsPrimo(int numero)
    {
        // Los números menores o iguales a 1 no son primos
        if (numero <= 1)
            return false;

        // Verificamos divisores hasta la raíz cuadrada
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
                return false; // Tiene divisor → no es primo
        }

        return true; // No tiene divisores → es primo
    }

    static void Main(string[] args)
    {
        // Declaramos un arreglo para almacenar 10 números
        int[] numeros = new int[10];

        // Variable para almacenar el mayor número primo
        int mayorPrimo = int.MinValue;

        // Variable para almacenar la posición del mayor primo
        int posicionMayorPrimo = -1;

        // Leemos los 10 números
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Recorremos el arreglo para buscar el mayor número primo
        for (int i = 0; i < numeros.Length; i++)
        {
            if (EsPrimo(numeros[i]))
            {
                if (numeros[i] > mayorPrimo)
                {
                    mayorPrimo = numeros[i];
                    posicionMayorPrimo = i;
                }
            }
        }

        // Mostramos el resultado
        if (posicionMayorPrimo != -1)
        {
            Console.WriteLine($"El mayor número primo es: {mayorPrimo}");
            Console.WriteLine($"Está en la posición (índice) {posicionMayorPrimo}");
            Console.WriteLine($"Posición humana: {posicionMayorPrimo + 1}");
        }
        else
        {
            Console.WriteLine("No se ingresaron números primos.");
        }

        
    }
}
