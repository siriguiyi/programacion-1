using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaramos un arreglo de 10 posiciones
        int[] numeros = new int[10];

        // Variable para almacenar la posición del mayor
        int posicionMayor = 0;

        // Leemos los 10 números
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Inicializamos el mayor con el primer elemento
        int mayor = numeros[0];

        // Recorremos el arreglo para encontrar el mayor
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
                posicionMayor = i; // Guardamos la posición
            }
        }

        // Mostramos el resultado
        Console.WriteLine($"El mayor número es: {mayor}");
        Console.WriteLine($"Está en la posición (índice) {posicionMayor}");
        Console.WriteLine($"Posición humana: {posicionMayor + 1}");

    }
}

