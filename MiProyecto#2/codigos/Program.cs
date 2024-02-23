bool error = true;
Console.WriteLine("Hola Amigo!");
Console.WriteLine("Este es un programa para el Cálculo del Área de una Figura Geométrica");
while (error)
{
    try
    {
        Console.WriteLine("Por favor, seleccione el tipo de figura geométrica:");
        Console.WriteLine("1. Triángulo");
        Console.WriteLine("2. Cuadrado");
        Console.WriteLine("3. Círculo");
        Console.Write("Ingrese el número correspondiente a la figura: ");
        int opcion = Convert.ToInt32(Console.ReadLine());
        double area = 0;
        if (opcion == 1)
        {
            Console.Write("Ingrese la base del triángulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la altura del triángulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            area = (baseTriangulo * alturaTriangulo) / 2;
        }
        else if (opcion == 2)
        {
            Console.Write("Ingrese el tamaño de los lados del cuadrado:");
            double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
            area = ladoCuadrado * ladoCuadrado;
        }
        else if (opcion == 3)
        {
            Console.Write("Ingrese el radio del círculo: ");
            double radioCirculo = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * Math.Pow(radioCirculo, 2);
        }
        else
        {
            Console.WriteLine("Opción no válida.");
            return;
        }
        Console.WriteLine("El área de la figura seleccionada es: " + area);

        error = false;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Uy! Parece que hubo un error, Lo quieres intentar de nuevo?");
        error= true;
    }
}
