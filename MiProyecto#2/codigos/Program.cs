Console.WriteLine("Hola Amigo!");
Console.WriteLine("Este es un programa para Calcular el Importe por Servicio");
Console.WriteLine("Tipos de servicio disponibles:");
Console.WriteLine("1. Lavado de auto");
Console.WriteLine("2. Cambio de aceite");
Console.WriteLine("3. Revisión mecánica");
Console.Write("Ingrese el número correspondiente al tipo de servicio: ");
int opcion = Convert.ToInt32(Console.ReadLine());

double importe = 0;
switch (opcion)
{
    case 1:
        importe = 25.00;
        break;
    case 2:
        importe = 50.00;
        break;
    case 3:
        importe = 100.00;
        break;
    default:
        Console.WriteLine("Opción no válida.");
        return;
}

Console.WriteLine($"El importe a pagar por el servicio seleccionado es: " + importe);
