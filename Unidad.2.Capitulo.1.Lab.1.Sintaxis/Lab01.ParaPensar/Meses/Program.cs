string[] meses = ["enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"];

Console.Write("Ingrese un mes: ");
string? mes = Console.ReadLine();

for (int i = 0; i <= 11; i++)
{
    if (mes.ToLower() == meses[i])
    {
        Console.WriteLine($"\nAl mes {meses[i]} le corresponde el numero {i+1}");
        Console.ReadKey();
    }
}