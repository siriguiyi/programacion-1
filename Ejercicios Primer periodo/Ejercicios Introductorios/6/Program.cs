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

        // Trabajamos con valor absoluto para separar los dígitos
        int n = Math.Abs(numero);

        // Extraemos los dígitos
        int centenas = n / 100;
        int decenas = (n / 10) % 10;
        int unidades = n % 10;

        bool esMultiplo = false;

        // Evitamos división entre cero verificando que el divisor no sea 0

        // Verificamos todas las combinaciones posibles
        if (decenas != 0 && centenas % decenas == 0) esMultiplo = true;
        if (unidades != 0 && centenas % unidades == 0) esMultiplo = true;

        if (centenas != 0 && decenas % centenas == 0) esMultiplo = true;
        if (unidades != 0 && decenas % unidades == 0) esMultiplo = true;

        if (centenas != 0 && unidades % centenas == 0) esMultiplo = true;
        if (decenas != 0 && unidades % decenas == 0) esMultiplo = true;

        // Mostramos el resultado
        if (esMultiplo)
            Console.WriteLine("Algún dígito es múltiplo de otro.");
        else
            Console.WriteLine("Ningún dígito es múltiplo de los otros.");

        
    }
}

