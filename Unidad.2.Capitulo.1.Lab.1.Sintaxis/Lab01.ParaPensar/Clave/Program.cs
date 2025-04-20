string? clave = "manzana";
int intentos = 0;
bool band = false;

while (intentos < 4)
{
    intentos++;
    Console.Write("Introduzca la clave: ");
    string? prueba = Console.ReadLine();

    if (prueba == clave)
    {
        band = true;
        intentos = 4;
    }

    else if (intentos != 4)
    {
        Console.WriteLine("\nError, vuelva a intentarlo\n");
    }
}

if (band == true)
{
    Console.WriteLine("\nClave correcta, bienvenido");
    Console.ReadKey();
}
else
{
    Console.WriteLine("\nIntentos maximos alcanzados");
    Console.ReadKey();
}
