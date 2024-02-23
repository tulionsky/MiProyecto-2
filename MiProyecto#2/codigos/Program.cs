Console.WriteLine("Seleccione su idioma de preferencia:");
Console.WriteLine("1. Español");
Console.WriteLine("2. Inglés");
Console.WriteLine("3. Francés");
Console.Write("Ingrese el número correspondiente a su idioma: ");
int opcion = Convert.ToInt32(Console.ReadLine());

string mensajeBienvenida;

switch (opcion)
{
    case 1:
        mensajeBienvenida = "¡Hola amigo!";
        break;
    case 2: // Inglés
        mensajeBienvenida = "Hello, My friend!";
        break;
    case 3: // Francés
        mensajeBienvenida = "Bonjour, mon ami!";
        break;
    default:
        Console.WriteLine("無效選項 (Opción no válida).");
        return;
}

Console.WriteLine(mensajeBienvenida);
