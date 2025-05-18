using FuncionesLINQ;
using FuncionesLinqTest;
using System;


FuncionesLinqT linq = new FuncionesLinqT();

Console.WriteLine("Menu\n\n1. Mostrar provincias que comienzan con 'S' o con 'T'\n2. Mostrar numero mayores a 20\n3. Mostrar codigos postales de ciudades ingresando inicial\n4. Dar de alta nuevos empleados y mostrar lista ordenada segun consideracion\n");
ConsoleKeyInfo opcion = Console.ReadKey();
switch (opcion.Key)
{
    case ConsoleKey.D1:
        linq.ObtenerProvinciasQueEmpiezanConDetermindasLetrasTest();
        Console.ReadKey();
        break;

    case ConsoleKey.D2:
        linq.ObtenerNumerosMayoresA20Test();
        Console.ReadKey();
        break;

    case ConsoleKey.D3:
        linq.ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminadosTest();
        Console.ReadKey();
        break;

    case ConsoleKey.D4:
        linq.AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldoTest();
        Console.ReadKey();
        break;

    default:
        Console.WriteLine("\nOpcion invalida");
        Console.ReadKey();
        break;
}