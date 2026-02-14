using System;
class Program
{
    // Función que determina si un año es bisiesto
    static bool EsBisiesto(int año)
    {
        /*
         Regla para que un año sea bisiesto:
         1. Debe ser divisible entre 4
         2. No debe ser divisible entre 100
         3. Excepto si también es divisible entre 400
        */

        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
        {
            return true;  // Es bisiesto
        }
        else
        {
            return false; // No es bisiesto
        }
    }

    // Método principal: punto de entrada del programa
    static void Main(string[] args)
    {
        // Se solicita al usuario que ingrese un año
        Console.Write("Ingrese un año: ");

        // Se convierte la entrada del usuario (string) a entero
        int año = Convert.ToInt32(Console.ReadLine());

        // Se llama a la función EsBisiesto y se guarda el resultado
        bool resultado = EsBisiesto(año);

        // Se muestra el resultado en pantalla
        if (resultado)
        {
            Console.WriteLine("El año " + año + " es bisiesto.");
        }
        else
        {
            Console.WriteLine("El año " + año + " no es bisiesto.");
        }

        
    }
}
