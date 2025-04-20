Console.Write("Ingrese un año: ");
int año = int.Parse(Console.ReadLine());

if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
{
    Console.WriteLine("\nEs un año bisiesto");
}
else
{
    Console.WriteLine("\nNo es un año bisiesto");
}
