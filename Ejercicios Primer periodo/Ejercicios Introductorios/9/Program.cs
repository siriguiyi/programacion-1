using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedimos un número entero de cuatro dígitos
        Console.Write("Ingrese un número entero de cuatro dígitos: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Validamos que sea de cuatro dígitos (positivo o negativo)
        if (!((numero >= 1000 && numero <= 9999) || (numero <= -1000 && numero >= -9999)))
        {
            Console.WriteLine("Error: Debe ingresar un número de cuatro dígitos.");
            return;
        }

        // Trabajamos con valor absoluto para separar los dígitos
        int n = Math.Abs(numero);

        // Extraemos los dígitos
        int miles = n / 1000;            // Primer dígito
        int centenas = (n / 100) % 10;   // Segundo dígito
        int decenas = (n / 10) % 10;     // Tercer dígito (penúltimo)
        int unidades = n % 10;           // Cuarto dígito

        // Verificamos si el segundo dígito (centenas)
        // es igual al penúltimo (decenas)
        if (centenas == decenas)
        {
            Console.WriteLine("El segundo dígito es igual al penúltimo.");
        }
        else
        {
            Console.WriteLine("El segundo dígito NO es igual al penúltimo.");
        }

    }
}
