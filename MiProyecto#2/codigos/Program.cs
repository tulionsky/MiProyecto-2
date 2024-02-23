bool error = true;
int num1;
Console.WriteLine("Bienvenido al Club **Los 3 Tiempos**");
while (error)
{
    try
    {
        Console.WriteLine("Porfavor ingrese su edad:");
        num1 = int.Parse(Console.ReadLine());
        if (num1 >= 18)
        {
            Console.WriteLine("BIENVENIDO! Puede ingresar.");
        }
        else
        {
            Console.WriteLine("No puedes entrar, lastima :/");
        }
        error = false;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Uy! Parece que hubo un error, Lo quieres intentar de nuevo?");
        error= true;
    }
}
