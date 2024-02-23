int calificacion;
Console.WriteLine("Ingresa la calificación del examen:");

if (!int.TryParse(Console.ReadLine(), out calificacion))
{
    Console.WriteLine("Error: ¡La calificación ingresada no es válida!");
    return;
}

switch (calificacion)
{
    case int n when (n >= 90 && n < 100):
        Console.WriteLine("Tu Calificación es Sobresaliente, *Felicidades amigo*");
        break;
    case int n when (n >= 80 && n < 90):
        Console.WriteLine("Tu Calificación es: Notable, *Bien hecho amigo*");
        break;
    case int n when (n >= 70 && n < 80):
        Console.WriteLine("Tu Calificación es: Aprobatoria, *Echale mas ganas la proxima*");
        break;
    case int n when (n >= 60 && n < 70):
        Console.WriteLine("Tu Calificación es: No aprobatoria, *Casi!! Por poco :/*");
        break;
    case int n when (n == 100):
        Console.WriteLine("**CAlIFICACION COMPLETA**");
        Console.WriteLine("**ERES EL EXITO AMIGO**");
        break;
    case int n when (n > 0 && n < 60):
        Console.WriteLine("*No estuviste ni cerca, pilas para la proxima!!*");
        break;
    case int n when (n == 0):
        Console.WriteLine("*En serio lo intentaste si quiera??*");
        break;
    default:
        Console.WriteLine("Error: ¡La calificación no está dentro del rango válido!");
        break;
}
