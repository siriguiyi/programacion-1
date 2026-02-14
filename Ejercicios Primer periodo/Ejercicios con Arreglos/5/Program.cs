using System;

class Program
{
    // Función para determinar si un número es primo
    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }

    // Función para contar cuántos dígitos pares tiene un número
    static int ContarDigitosPares(int numero)
    {
        int contador = 0;
        int n = Math.Abs(numero);

        // Recorremos cada dígito
        while (n > 0)
        {
            int digito = n % 10;

            if (digito % 2 == 0) // Si el dígito es par
                contador++;

            n /= 10;
        }

        return contador;
    }

    static void Main(string[] args)
    {
        int[] numeros = new int[10];

        int posicion = -1;
        int maxDigitosPares = -1;

        // Leer los 10 números
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Buscar el número primo con mayor cantidad de dígitos pares
        for (int i = 0; i < numeros.Length; i++)
        {
            if (EsPrimo(numeros[i]))
            {
                int cantidadPares = ContarDigitosPares(numeros[i]);

                if (cantidadPares > maxDigitosPares)
                {
                    maxDigitosPares = cantidadPares;
                    posicion = i;
                }
            }
        }

        // Mostrar resultado
        if (posicion != -1)
        {
            Console.WriteLine($"El número primo con más dígitos pares está en la posición (índice): {posicion}");
            Console.WriteLine($"Posición humana: {posicion + 1}");
            Console.WriteLine($"Cantidad de dígitos pares: {maxDigitosPares}");
        }
        else
        {
            Console.WriteLine("No se ingresaron números primos.");
        }

    }
}

