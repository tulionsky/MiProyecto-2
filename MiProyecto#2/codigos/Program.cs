int num1;
bool error = true;
Console.WriteLine("Hola Amigo!");
Console.WriteLine("Este es un programa para Convertir un Número de Letra a Número");
Console.Write("Ingrese un número del 1 al 5 en letra (\"uno\", \"dos\", \"tres\", \"cuatro\", \"cinco\"): ");
string numeroLetra = Console.ReadLine().ToLower(); 
int numero;
switch (numeroLetra)
{
    case "uno":
        numero = 1;
        break;
    case "dos":
        numero = 2;
        break;
    case "tres":
        numero = 3;
        break;
    case "cuatro":
        numero = 4;
        break;
    case "cinco":
        numero = 5;
        break;
    default:
        Console.WriteLine("Número de letra no válido.");
        return;
}
Console.WriteLine($"El número en dígito es: " +numero);
