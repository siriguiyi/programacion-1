using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedimos el primer número entero de dos dígitos
        Console.Write("Ingrese el primer número entero de dos dígitos: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        // Pedimos el segundo número entero de dos dígitos
        Console.Write("Ingrese el segundo número entero de dos dígitos: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        // Validamos que ambos sean de dos dígitos (positivo o negativo)
        bool valido1 = (numero1 >= 10 && numero1 <= 99) || (numero1 <= -10 && numero1 >= -99);
        bool valido2 = (numero2 >= 10 && numero2 <= 99) || (numero2 <= -10 && numero2 >= -99);

        if (!valido1 || !valido2)
        {
            Console.WriteLine("Error: Ambos números deben ser de dos dígitos.");
            return;
        }

        // Calculamos la suma
        int suma = numero1 + numero2;

        // Determinamos si la suma es par usando el operador módulo %
        if (suma % 2 == 0)
        {
            Console.WriteLine($"La suma ({suma}) es un número par.");
        }
        else
        {
            Console.WriteLine($"La suma ({suma}) es un número impar.");
        }

    
    }
}

