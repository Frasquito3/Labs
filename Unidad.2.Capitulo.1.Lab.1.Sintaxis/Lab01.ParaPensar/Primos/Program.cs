Console.Write("Ingrese cuantos pares de primos gemelos quiere ver: ");
int cantidad = int.Parse(Console.ReadLine());

int contador = 0;
int primo1 = 2;

while (contador < cantidad)
{
    int divisores1 = 0;
    for (int i = 1; i <= primo1; i++)
    {
        if (primo1 % i == 0)
        {
            divisores1++;
        }
    }

    if(divisores1 == 2)
    {
        int primo2 = primo1 + 2;
        int divisores2 = 0;
        for (int i = 1; i <= primo2; i++)
        {
            if (primo2 % i == 0)
            {
                divisores2++;
            }
        }
        if (divisores2 == 2)
        {
            Console.WriteLine($"({primo1},{primo2})");
            contador++;
        }
    }
    primo1++;
}