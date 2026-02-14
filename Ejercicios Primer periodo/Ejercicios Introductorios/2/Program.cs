using System;

class Program
{
    // Función para determinar si un número es primo
    static bool EsPrimo(int numero)
    {
        // Los números menores o iguales a 1 no son primos
        if (numero <= 1)
            return false;

        // Solo verificamos hasta la raíz cuadrada del número
        for (int i = 2; i * i <= numero; i++)
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

        // Verificamos si es negativo
        if (numero < 0)
            Console.WriteLine("El número es negativo.");
        else
            Console.WriteLine("El número no es negativo.");

        // Para evaluar si es primo usamos el valor absoluto
        int valorAbsoluto = Math.Abs(numero);

        if (EsPrimo(valorAbsoluto))
            Console.WriteLine("El número es primo.");
        else
            Console.WriteLine("El número no es primo.");

    }
}
