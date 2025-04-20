Console.Write("Ingrese un texto: ");
string? inputTexto = Console.ReadLine();

if (inputTexto != "" && inputTexto != null)
{
    Console.WriteLine("\nMenu\n\n1. Mayusculas\n2. Minusculas\n3. Cantidad de caracteres\n");
    ConsoleKeyInfo opcion = Console.ReadKey();
    switch (opcion.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine("\nEl texto en mayusculas es: " + inputTexto.ToUpper());
            break;

        case ConsoleKey.D2:
            Console.WriteLine("\nEl texto en minusculas es: " + inputTexto.ToLower());
            break;

        case ConsoleKey.D3:
            Console.WriteLine("\nEl texto tiene la siguiente cantidad de caracteres: " + inputTexto.Length);
            break;

        default:
            Console.WriteLine("\nOpcion invalida");
            break;
    }
}
else
{
    Console.WriteLine("El texto ingresado esta vacio");
}
