using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncionesLINQ
{
    public class FuncionesLinq
    {
        public IEnumerable<string> ObtenerProvinciasQueEmpiezanConDeterminadasLetras(IEnumerable<string> provincias)
        {
            var selectProv = (from p in provincias
                              where p.StartsWith("S") || p.StartsWith("T")
                              select p);
            return selectProv;
        }

        public IEnumerable<int> ObtenerNumerosMayoresA20(IEnumerable<int> numeros)
        {
            var numMayor20 = (from n in numeros
                              where n > 20
                              select n);
            return numMayor20;
        }

        public IEnumerable<int> ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminados(IEnumerable<Ciudad> ciudades, string ciudad)
        {
            var codPostalCiudades = (from c in ciudades
                                     where c.Nombre.ToLower().StartsWith(ciudad)
                                     select c.CodigoPostal);
            return codPostalCiudades;
        }

        public IEnumerable<Empleado> AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldo(IEnumerable<Empleado> empleados, IEnumerable<Empleado> empleadosParaAgregar, string order)
        {
            var altaEmpleados = empleados.Concat(empleadosParaAgregar);

            if (order.ToUpper() == "ASC")
            {
                var empleadosOrdenadosPorSueldo = (from e in altaEmpleados
                                                   orderby e.Sueldo ascending
                                                   select e);
                return empleadosOrdenadosPorSueldo;
            }
            else if (order.ToUpper() == "DESC")
            {
                var empleadosOrdenadosPorSueldo = (from e in altaEmpleados
                                                   orderby e.Sueldo descending
                                                   select e);
                return empleadosOrdenadosPorSueldo;
            }
            else
            {
                throw new ArgumentException("El orden debe ser ASC o DESC");
            }
        }
    }
}
