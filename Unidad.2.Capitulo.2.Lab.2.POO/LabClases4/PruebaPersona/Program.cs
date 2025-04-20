using System;
using Clases;

class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona("Juan","Tinturelli", 30, "45215900");

        Console.WriteLine($"Nombre completo: {persona.getFullName()}" );
        Console.WriteLine($"Edad: {persona.getAge()}");
        Console.WriteLine($"DNI: {persona.Dni}");

        Console.ReadKey();
    }
}


