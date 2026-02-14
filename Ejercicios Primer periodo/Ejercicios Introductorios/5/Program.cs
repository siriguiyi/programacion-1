using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedimos un número entero de tres dígitos
        Console.Write("Ingrese un número entero de tres dígitos: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Validamos que sea de tres dígitos (positivo o negativo)
        if (!((numero >= 100 && numero <= 999) || (numero <= -100 && numero >= -999)))
        {
            Console.WriteLine("Error: Debe ingresar un número de tres dígitos.");
            return;
        }

        // Trabajamos con el valor absoluto para separar los dígitos
        int n = Math.Abs(numero);

        // Extraemos los dígitos
        int centenas = n / 100;            // Primer dígito
        int decenas = (n / 10) % 10;       // Segundo dígito
        int unidades = n % 10;             // Tercer dígito

        // Determinamos cuál es el mayor
        int mayor = centenas;
        string posicion = "centenas";

        if (decenas > mayor)
        {
            mayor = decenas;
            posicion = "decenas";
        }

        if (unidades > mayor)
        {
            mayor = unidades;
            posicion = "unidades";
        }

        // Mostramos el resultado
        Console.WriteLine($"El mayor dígito es {mayor} y está en la posición de {posicion}.");

    }
}
