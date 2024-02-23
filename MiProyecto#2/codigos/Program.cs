string usuario, contra; 
bool error = true;
Console.WriteLine("Hola Amigo!");
Console.WriteLine("Deseas iniciar sesion?");
while (error)
{
    try
    {
        Console.WriteLine("Porfavor ingrese su usuario:");
        usuario = Console.ReadLine();
        usuario = usuario.ToUpper();
        Console.WriteLine("Porfavor ingrese su Contraseña:");
        contra = Console.ReadLine();
        contra = contra.ToUpper();
        if (usuario == "USUARIO" && contra == "CONTRASEÑA")
        {
            Console.WriteLine("Contraseña y usuario correctos, puede ingrear.");
        }
        else
        {
            Console.WriteLine("Su contraseña y/o usuarios son incorrectos, agreguelos nuevamente");
        }


        error = false;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Uy! Parece que hubo un error, Lo quieres intentar de nuevo?");
        error= true;
    }
}
