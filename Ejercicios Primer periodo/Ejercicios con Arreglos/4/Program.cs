using System;

class Program
{
    // Función que determina si un dígito (0-9) es primo
    static bool DigitoEsPrimo(int d)
    {
        return d == 2 || d == 3 || d == 5 || d == 7;
    }

    // Función para obtener el primer dígito de un número (ej: 156 -> 1, -987 -> 9)
    static int PrimerDigito(int numero)
    {
        int n = Math.Abs(numero); // ignoramos el signo

        // Caso especial: si el número es 0, su primer dígito es 0
        if (n == 0) return 0;

        // Quitamos dígitos por la derecha hasta quedarnos con el primero
        while (n >= 10)
        {
            n /= 10;
        }

        return n; // aquí queda el primer dígito
    }

    static void Main(string[] args)
    {
        int[] numeros = new int[10];
        int contador = 0;

        // Leer 10 números y almacenarlos
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Recorrer el arreglo y contar los que comienzan con dígito primo
        for (int i = 0; i < numeros.Length; i++)
        {
            int primerDigito = PrimerDigito(numeros[i]);

            if (DigitoEsPrimo(primerDigito))
            {
                contador++;
            }
        }

        // Mostrar resultado
        Console.WriteLine($"Cantidad de números que comienzan con dígito primo (2,3,5,7): {contador}");

       
    }
}
