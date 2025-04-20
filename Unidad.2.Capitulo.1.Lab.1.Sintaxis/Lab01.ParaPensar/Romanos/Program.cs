Console.Write("Ingrese un numero entero (1 a 3999): ");
int numero = int.Parse(Console.ReadLine());

if (numero < 1 || numero > 3999)
{
    Console.WriteLine("Numero invalido");
}

else
{
    string resultado = "";

    string[] simbolos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
    int[] valores = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

    for (int i = 0; i < valores.Length; i++)
    {
        while (numero >= valores[i])
        {
            resultado += simbolos[i];
            numero -= valores[i];
        }
    }
    Console.WriteLine($"\nEl numero romano es: {resultado}");
}