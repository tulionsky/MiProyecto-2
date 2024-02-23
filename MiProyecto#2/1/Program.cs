int num1, num2, num3;
bool error = true;
Console.WriteLine("Hola Amigo!");
Console.WriteLine("Este es un programa para ver cual de los 3 numeros es el mayor");
while (error)
{
    try
    {
        Console.WriteLine("Por favor ingresa el primer numero:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Por favor ingresa el segundo numero:");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Por favor ingresa el tercer numero:");
        num3 = int.Parse(Console.ReadLine());
        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("El numero " + num1 + " es el mayor.");
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine("El numero " + num2 + " es el mayor.");
        }
        else if ((num3 > num2) && (num3 > num1))
        {
            Console.WriteLine("El numero " + num3 + " es el mayor.");
        }
        else 
        {
            Console.WriteLine("Todos son iguales");
        }
        error= false;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Uy! Parece que hubo un error, Lo quieres intentar de nuevo?");
        error= true;
    }
}
