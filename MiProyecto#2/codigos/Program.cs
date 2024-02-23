bool error = true;
Console.WriteLine("Hola Amigo!");
Console.WriteLine("Este es un programa para ver si su prestamo es aprobado o no.");
while (error)
{
    try
    {
        Console.Write("Ingrese el monto del préstamo: ");
        decimal montoPrestamo = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese su edad: ");
        int edadUsuario = Convert.ToInt32(Console.ReadLine());

        if (montoPrestamo < 5000 || edadUsuario > 60)
        {
            Console.WriteLine("Felicidades, su préstamo ha sido aprobado.");
        }
        else
        {
            Console.WriteLine("Lo sentimos, su solicitud de préstamo ha sido rechazada.");
        }

        error = false;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Uy! Parece que hubo un error, Lo quieres intentar de nuevo?");
        error= true;
    }
}
