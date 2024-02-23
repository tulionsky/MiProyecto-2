int num1;
bool error = true;
Console.WriteLine("Hola Amigo!");
Console.WriteLine("Este es un programa para ver si su numero es PAR o IMPAR");
while (error)
{
    try
    {
        Console.WriteLine("Porfavor ingrese un numero:");
        num1 = int.Parse(Console.ReadLine());

        if (num1 % 2 == 0)
        {
            Console.WriteLine("El numero ingresado es PAR");
        }
        else
        {
            Console.WriteLine("El numero ingresado es IMPAR");
        }
        error = false;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Uy! Parece que hubo un error, Lo quieres intentar de nuevo?");
        error= true;
    }
}
