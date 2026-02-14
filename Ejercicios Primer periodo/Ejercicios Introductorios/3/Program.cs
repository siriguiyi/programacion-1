using System;

class Program
{
    // Función para determinar si un número es primo
    static bool EsPrimo(int numero)
    {
        // Los números menores o iguales a 1 no son primos
        if (numero <= 1)
            return false;

        // Verificamos divisores desde 2 hasta numero - 1
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
                return false; // Tiene divisor → no es primo
        }

        return true; // No tiene divisores → es primo
    }

    static void Main(string[] args)
    {
        // Pedimos un número entero de dos dígitos
        Console.Write("Ingrese un número entero de dos dígitos: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Validamos que sea de dos dígitos (positivo o negativo)
        if (!((numero >= 10 && numero <= 99) || (numero <= -10 && numero >= -99)))
        {
            Console.WriteLine("Error: Debe ingresar un número de dos dígitos.");
            return;
        }

        // Trabajamos con el valor absoluto para separar los dígitos
        int n = Math.Abs(numero);

        // Obtenemos los dígitos
        int decenas = n / 10;   // Primer dígito
        int unidades = n % 10;  // Segundo dígito

        // Verificamos si ambos dígitos son primos
        if (EsPrimo(decenas) && EsPrimo(unidades))
        {
            Console.WriteLine("Ambos dígitos son números primos.");
        }
        else
        {
            Console.WriteLine("No ambos dígitos son números primos.");
        }

    }
}

