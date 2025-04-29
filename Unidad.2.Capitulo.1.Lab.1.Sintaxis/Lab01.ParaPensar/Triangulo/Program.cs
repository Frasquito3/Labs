Console.Write("Ingrese el numero de filas del triangulo: ");
int filas = int.Parse(Console.ReadLine());

for (int i = 1; i <= filas; i++)
{
    for (int j = 1; j <= filas - i; j++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
Console.ReadKey();
