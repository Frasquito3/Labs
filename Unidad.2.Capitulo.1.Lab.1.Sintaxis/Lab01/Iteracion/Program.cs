int cantIteraciones = 5;
string[] arr = new string[cantIteraciones];

for (int i = 0; i < cantIteraciones; i++)
{
    Console.WriteLine("Texto en la posicion: " + i);
    arr[i] = Console.ReadLine();
}

Console.WriteLine("\n");

for (int i = cantIteraciones - 1; i >= 0; i--)
{
    Console.WriteLine("Texto en la posicion: " + i);
    Console.WriteLine(arr[i]);
}
