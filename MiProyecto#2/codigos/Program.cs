Double num1, num2, num3; 
bool error = true;
Console.WriteLine("Hola Amigo!");
Console.WriteLine("Este es un programa para ver el precio de su producto");
while (error)
{
    try
    {
        Console.WriteLine("Porfavor ingrese el precio de su producto:");
        num1 = double.Parse(Console.ReadLine());
        if (num1 > 100)
        {
            num2 = num1 * 0.10;
            num3 = num1 - num2;

            Console.WriteLine("El precio de su producto es de: " + num3);
        }
        else
        {
            Console.WriteLine("El precio de su producto es de: " + num1);
        }

        error = false;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Uy! Parece que hubo un error, Lo quieres intentar de nuevo?");
        error= true;
    }
}
