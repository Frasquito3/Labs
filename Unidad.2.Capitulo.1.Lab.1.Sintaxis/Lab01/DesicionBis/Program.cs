﻿Console.Write("Ingrese un texto: ");
string? inputTexto = Console.ReadLine();

if (inputTexto != "" && inputTexto != null)
{
    Console.WriteLine("\nMenu\n\n1. Mayusculas\n2. Minusculas\n3. Cantidad de caracteres\n");
    ConsoleKeyInfo opcion = Console.ReadKey();
    switch (opcion.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine("\nEl texto en mayusculas es: " + inputTexto.ToUpper());
            Console.ReadKey();
            break;

        case ConsoleKey.D2:
            Console.WriteLine("\nEl texto en minusculas es: " + inputTexto.ToLower());
            Console.ReadKey();
            break;

        case ConsoleKey.D3:
            Console.WriteLine("\nEl texto tiene la siguiente cantidad de caracteres: " + inputTexto.Length);
            Console.ReadKey();
            break;

        default:
            Console.WriteLine("\nOpcion invalida");
            Console.ReadKey();
            break;
    }
}
else
{
    Console.WriteLine("El texto ingresado esta vacio");
    Console.ReadKey();
}
