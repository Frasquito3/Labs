using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        private double baseRectangulo;
        private double altura;

        public double Base
        {
            get { return baseRectangulo; }
            set { baseRectangulo = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public override double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + altura);
        }

        public override double CalcularSuperficie()
        {
            return baseRectangulo * altura;
        }
    }
}