using FuncionesLINQ;
using System;
using System.Collections.Generic;
using Xunit;

namespace FuncionesLinqTest
{
    public class FuncionesLinqT
    {
        [Fact]
        public void ObtenerProvinciasQueEmpiezanConDetermindasLetrasTest()
        {
            Console.Clear();
            // Arrange
            var funcionesLinq = new FuncionesLinq();
            IEnumerable<string> provincias = new List<string>
            {
                "Buenos Aires",
                "Capital Federal",
                "Catamarca",
                "Chaco",
                "Chubut",
                "Córdoba",
                "Corrientes",
                "Entre Ríos",
                "Formosa",
                "Jujuy",
                "La Pampa",
                "La Rioja",
                "Mendoza",
                "Misiones",
                "Neuquén",
                "Río Negro",
                "Salta",
                "San Juan",
                "San Luis",
                "Santa Cruz",
                "Santa Fe",
                "Santiago del Estero",
                "Tierra del Fuego, Antártida e Isla del Atlántico Sur",
                "Tucumán"
            };
            
            // Act
            IEnumerable<string> provinciasSeleccionadas = funcionesLinq.ObtenerProvinciasQueEmpiezanConDeterminadasLetras(provincias);
            foreach(string p in provinciasSeleccionadas) {
                Console.WriteLine(p);
                };
 
            // Assert (los assert se utilizan para verificaciones)
            Assert.Equal(expected: new List<String>
            {
                "Salta",
                "San Juan",
                "San Luis",
                "Santa Cruz",
                "Santa Fe",
                "Santiago del Estero",
                "Tierra del Fuego, Antártida e Isla del Atlántico Sur",
                "Tucumán",
            }, actual: provinciasSeleccionadas);
        }

        [Fact]
        public void ObtenerNumerosMayoresA20Test()
        {
            Console.Clear();
            // Arrange
            var funcionesLinq = new FuncionesLinq();
            IEnumerable<int> numeros = new List<int> { 14, 2, 5, 21, 32, 25, 234, 4, 7, 90, 123, 1, 19};

            // Act
            IEnumerable<int> numerosMayoresA20 = funcionesLinq.ObtenerNumerosMayoresA20(numeros);

            foreach (int n in numerosMayoresA20)
            {
                Console.WriteLine(n);
            }
            ;
            
            // Assert
            Assert.Equal(expected: new List<int> { 21, 32, 25, 234, 90, 123 }, actual: numerosMayoresA20);
            Assert.DoesNotContain(20, numerosMayoresA20);

            //Agregadito de prueba
            Assert.Contains(21, numerosMayoresA20);
        }

        [Fact]
        public void ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminadosTest()
        {
            Console.Clear();
            // Arrange
            var funcionesLinq = new FuncionesLinq();
            IEnumerable<Ciudad> ciudades = new List<Ciudad>
            {
                 new Ciudad() { Nombre = "Rosario", CodigoPostal = 2000 },
                 new Ciudad()
                 {
                     Nombre = "Córdoba",
                     CodigoPostal = 5000
                 },
                new Ciudad()
                {
                    Nombre = "Santa Fe",
                    CodigoPostal = 3000
                },
                new Ciudad() {
                    Nombre = "San Miguel De Tucuman",
                    CodigoPostal = 4000
                },
                new Ciudad()
                {
                    Nombre = "Villa Constitucion",
                    CodigoPostal = 2919
                },
                new Ciudad()
                {
                    Nombre = "Arroyo Seco",
                    CodigoPostal = 2128
                },
                new Ciudad()
                {
                    Nombre = "Villa Crespo",
                    CodigoPostal = 1417
                },
                new Ciudad()
                {
                    Nombre = "Villa Maria",
                    CodigoPostal = 5220
                },
                new Ciudad()
                {
                    Nombre = "Arroyo Hondo",
                    CodigoPostal = 3190
                },
                new Ciudad()
                {
                    Nombre = "Venado Tuerto",
                    CodigoPostal = 2600
                },
                new Ciudad()
                {
                    Nombre = "San Nicolas",
                    CodigoPostal = 2900
                },
            };

            Console.Write("Ingrese las iniciales de la ciudad que desea buscar: ");
            string inicial = Console.ReadLine();
            Console.Write("\n");

            // Act
            IEnumerable<int> codPostalesDeCiudadesSeleccionadas = funcionesLinq.ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminados(ciudades, inicial);

            foreach (int c in codPostalesDeCiudadesSeleccionadas)
            {
                Console.WriteLine(c);
            }

            // Assert
            //Assert.Equal(expected: new List<int> { 3000, 4000, 2900 }, actual: codPostalesDeCiudadesSeleccionadas);
        }

        [Fact]
        public void AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldoTest()
        {
            Console.Clear();
            // Arrange
            var funcionesLinq = new FuncionesLinq();

            var empleados = new List<Empleado> { new Empleado() { Id = 1, Nombre = "Gabriela F", Sueldo = 1600.0}, new Empleado() { Id = 2, Nombre = "Federico R", Sueldo = 1200.0} };
            var empleadosParaAgregar = new List<Empleado> { new Empleado() { Id = 3, Nombre = "Juan D", Sueldo = 1500.0 }, new Empleado() { Id = 4, Nombre = "Jesus T", Sueldo = 1610.5} };

            Console.Write("Ingrese orden que desea visualizar (ASC o DESC): ");
            string orden = Console.ReadLine();
            Console.Write("\n");

            // Act
            IEnumerable<Empleado> empleadosOrdenadosPorSueldo = funcionesLinq.AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldo(empleados, empleadosParaAgregar, orden);

            foreach (Empleado e in empleadosOrdenadosPorSueldo)
            {
                Console.WriteLine($"Id: {e.Id}, Nombre: {e.Nombre}, Sueldo: {e.Sueldo}");
            }

            // Assert
            //Assert.Equal(expected: new List<Empleado> { empleados[1], empleadosParaAgregar[0], empleados[0], empleadosParaAgregar[1] }, actual: empleadosOrdenadosPorSueldo);

            // Assert para orden descendente
            //Assert.Equal(expected: new List<Empleado> { empleadosParaAgregar[1], empleados[0], empleadosParaAgregar[0], empleados[1] }, actual: empleadosOrdenadosPorSueldo);
        }
    }
}
