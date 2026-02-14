using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;   // Variable para leer cada número
        int mayor;    // Variable para almacenar el mayor

        // Leemos el primer número
        Console.Write("Ingrese el primer número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        // Inicializamos "mayor" con el primer número
        mayor = numero;

        // Leemos el segundo número
        Console.Write("Ingrese el segundo número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        // Si el segundo número es mayor, actualizamos
        if (numero > mayor)
        {
            mayor = numero;
        }

        // Leemos el tercer número
        Console.Write("Ingrese el tercer número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        // Si el tercer número es mayor, actualizamos
        if (numero > mayor)
        {
            mayor = numero;
        }

        // Mostramos el resultado final
        Console.WriteLine("El número mayor es: " + mayor);

        
    }
}

