Console.Write("Ingrese la cantidad de terminos de Fibonacci a sumar: ");
int cant = int.Parse(Console.ReadLine());

int a = 0, b = 1, suma = 0;

for (int i = 0; i < cant; i++)
{
    suma += a;
    int aux = a;
    a = b;
    b = aux + b;
}

Console.WriteLine($"\nLa suma de los primeros {cant} terminos de Fibonacci es: {suma}");