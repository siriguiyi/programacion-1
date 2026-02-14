using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedimos un número entero de cinco dígitos
        Console.Write("Ingrese un número entero de cinco dígitos: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Validamos que sea de cinco dígitos (positivo o negativo)
        if (!((numero >= 10000 && numero <= 99999) || (numero <= -10000 && numero >= -99999)))
        {
            Console.WriteLine("Error: Debe ingresar un número de cinco dígitos.");
            return;
        }

        // Trabajamos con valor absoluto para separar los dígitos
        int n = Math.Abs(numero);

        // Extraemos los dígitos
        int d1 = n / 10000;              // Primer dígito
        int d2 = (n / 1000) % 10;        // Segundo dígito
        int d3 = (n / 100) % 10;         // Tercer dígito
        int d4 = (n / 10) % 10;          // Cuarto dígito
        int d5 = n % 10;                 // Quinto dígito

        // Un número es capicúa si:
        // 1er dígito == 5to dígito
        // 2do dígito == 4to dígito
        if (d1 == d5 && d2 == d4)
        {
            Console.WriteLine("El número es capicúa.");
        }
        else
        {
            Console.WriteLine("El número NO es capicúa.");
        }

      
    }
}
