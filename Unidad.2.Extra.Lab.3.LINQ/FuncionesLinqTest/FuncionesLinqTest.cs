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
            /*
            // Assert
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
            }, actual: provinciasSeleccionadas);*/
        }

        [Fact]
        public void ObtenerNumerosMayoresA20Test()
        {
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
            /*
            // Assert
            Assert.Equal(expected: new List<int> { 21, 32, 25 }, actual: numerosMayoresA20);
            Assert.DoesNotContain(20, numerosMayoresA20);*/
        }

        [Fact]
        public void ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminadosTest()
        {
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
                    Nombre = "papapapa",
                    CodigoPostal = 6969
                },
                new Ciudad()
                {
                    Nombre = "pipipipi",
                    CodigoPostal = 7777
                },
                new Ciudad()
                {
                    Nombre = "pepepepe",
                    CodigoPostal = 6666
                },
                new Ciudad()
                {
                    Nombre = "popopopo",
                    CodigoPostal = 9999
                },
                new Ciudad()
                {
                    Nombre = "pupupupu",
                    CodigoPostal = 3333
                },
                new Ciudad()
                {
                    Nombre = "kkkk",
                    CodigoPostal = 1212
                },
            };

            // Act
            IEnumerable<int> codPostalesDeCiudadesSeleccionadas = funcionesLinq.ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminados(ciudades, "san");

            foreach (int c in codPostalesDeCiudadesSeleccionadas)
            {
                Console.WriteLine(c);
            }

            // Assert
            //Assert.Equal(expected: new List<int> { 3000, 4000 }, actual: codPostalesDeCiudadesSeleccionadas);
        }

        [Fact]
        public void AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldoTest()
        {
            // Arrange
            var funcionesLinq = new FuncionesLinq();

            var empleados = new List<Empleado> { new Empleado() { Id = 1, Nombre = "Gabriela F", Sueldo = 1600.0}, new Empleado() { Id = 2, Nombre = "Federico R", Sueldo = 1200.0} };
            var empleadosParaAgregar = new List<Empleado> { new Empleado() { Id = 3, Nombre = "Juan D", Sueldo = 1500.0 }, new Empleado() { Id = 4, Nombre = "Jesus T", Sueldo = 1610.5} };

            // Act
            IEnumerable<Empleado> empleadosOrdenadosPorSueldo = funcionesLinq.AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldo(empleados, empleadosParaAgregar, "ASC");

            // Assert
            Assert.Equal(expected: new List<Empleado> { empleados[1], empleadosParaAgregar[0], empleados[0], empleadosParaAgregar[1] }, actual: empleadosOrdenadosPorSueldo);
        }
    }
}
