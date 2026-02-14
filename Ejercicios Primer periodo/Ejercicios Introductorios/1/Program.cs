Console.Write("Ingrese un número entero de dos dígitos: ");
int numero = Convert.ToInt32(Console.ReadLine());
//validacion
if (!((numero >= 10 && numero <= 99) || (numero <= -10 && numero >= -99)))
{
Console.WriteLine("Error: Debe ingresar un número entero de dos dígitos (ej: 15 o -42).");
return;
}

// Para manejar negativos, trabajamos con el valor absoluto
int n = Math.Abs(numero);

// Obtenemos el dígito de las unidades (último dígito) con el módulo %
int unidades = n % 10;

// Obtenemos el dígito de las decenas usando división entera /
int decenas = n / 10;

// Sumamos ambos dígitos
int suma = decenas + unidades;

// Mostramos el resultado
Console.WriteLine($"La suma de los dígitos de {numero} es: {suma}");

